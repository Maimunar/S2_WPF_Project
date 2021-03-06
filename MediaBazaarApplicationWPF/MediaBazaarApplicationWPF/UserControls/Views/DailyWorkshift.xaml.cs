﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MediaBazaarApplicationWPF.UserControls
{
    /// <summary>
    /// Interaction logic for DailyWorkshift.xaml
    /// </summary>
    public partial class DailyWorkshift : UserControl
    {
        private WorkshiftsManager manager;
        private Employee employee;
        private readonly DateTime date;

        public Employee Employee => this.employee;
        public DateTime Date => this.date;

        public DailyWorkshift(Employee employee, DateTime date)
        {
            InitializeComponent();
            this.employee = employee;
            this.date = date;

            tbShiftOneStart.Text = "9:00";
            tbShiftTwoStart.Text = "13:00";
            tbShiftThreeStart.Text = "17:00";
            tbShiftThreeEnd.Text = "21:00";

            manager = new WorkshiftsManager(this.Employee, this.Date);
            manager.SetWorkshiftPanels(workshiftOneCell, workshiftTwoCell, workshiftThreeCell);

            this.lblEmployeeName.Text = Employee.FullName;

            if (date.Date <= DateTime.Now.Date)
            {
                var managementMenu = (this.Resources["managementMenu"] as ContextMenu);
                for (int i = 0; i < managementMenu.Items.Count; i++) (managementMenu.Items[i] as MenuItem).IsEnabled = false;

                var requestsMenu = (this.Resources["requestsMenu"] as ContextMenu);
                for (int i = 0; i < requestsMenu.Items.Count; i++) (requestsMenu.Items[i] as MenuItem).IsEnabled = false;
            }

            if (LoggedInUser.role != EmployeeRole.Worker)
            {
                this.workshiftOneCell.ContextMenu = this.workshiftTwoCell.ContextMenu = this.workshiftThreeCell.ContextMenu = (this.Resources["managementMenu"] as ContextMenu);
                this.workshiftOneCell.ContextMenuOpening += new ContextMenuEventHandler(managementMenu_ContextMenuOpening);
                this.workshiftTwoCell.ContextMenuOpening += new ContextMenuEventHandler(managementMenu_ContextMenuOpening);
                this.workshiftThreeCell.ContextMenuOpening += new ContextMenuEventHandler(managementMenu_ContextMenuOpening);
            }
            else if (LoggedInUser.userID == employee.UserID)
            {
                this.workshiftOneCell.ContextMenu = this.workshiftTwoCell.ContextMenu = this.workshiftThreeCell.ContextMenu = (this.Resources["requestsMenu"] as ContextMenu);
                this.workshiftOneCell.ContextMenuOpening += new ContextMenuEventHandler(requestsMenu_ContextMenuOpening);
                this.workshiftTwoCell.ContextMenuOpening += new ContextMenuEventHandler(requestsMenu_ContextMenuOpening);
                this.workshiftThreeCell.ContextMenuOpening += new ContextMenuEventHandler(requestsMenu_ContextMenuOpening);
            }
        }

        public void ShowHeader()
        {
            this.headerRow.Height = new GridLength(0, GridUnitType.Auto);
        }

        public void SetStatus(int status, int index) { manager.SetStatus(status, index); }
        public void SetStatus(WorkshiftStatus status, int index) { manager.SetStatus(status, index); }

        public int? GetWorkshiftIndex(string objectName)
        {
            int? index = null;
            switch (objectName)
            {
                case "workshiftOneCell": index = 0; break;
                case "workshiftTwoCell": index = 1; break;
                case "workshiftThreeCell": index = 2; break;
            }
            return index;
        }

        private void managementMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            this.manager.SelectedWorkshiftIndex = GetWorkshiftIndex((sender as Canvas).Name);

            if(this.manager.SelectedWorkshiftIndex != null)
            {
                int index = (int)this.manager.SelectedWorkshiftIndex;

                var managementMenu = (this.Resources["managementMenu"] as ContextMenu);

                if (date.Date > DateTime.Now.Date)
                {
                    (managementMenu.Items[0] as MenuItem).IsEnabled = (this.manager.StatusIndex[index] != 1) ? false : true;
                    (managementMenu.Items[1] as MenuItem).IsEnabled = (this.manager.StatusIndex[index] != 1) ? false : true;
                }   
                for (int i = 2; i < managementMenu.Items.Count; i ++) (managementMenu.Items[i] as MenuItem).Visibility = (this.manager.StatusIndex[index] != 1) ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private void requestsMenu_ContextMenuOpening(object sender, ContextMenuEventArgs e)
        {
            this.manager.SelectedWorkshiftIndex = GetWorkshiftIndex((sender as Canvas).Name);
            
            if(this.manager.SelectedWorkshiftIndex != null)
            {
                int index = (int)this.manager.SelectedWorkshiftIndex;

                var requestsMenu = (this.Resources["requestsMenu"] as ContextMenu);
                if (date.Date > DateTime.Now.Date)
                {
                    (requestsMenu.Items[0] as MenuItem).IsEnabled = (this.manager.StatusIndex[index] == 0 || this.manager.StatusIndex[index] == 1) ? true : false;
                }
                (requestsMenu.Items[0] as MenuItem).Visibility = (this.manager.StatusIndex[index] != (int)WorkshiftStatus.Pending) ? Visibility.Visible : Visibility.Collapsed;
                (requestsMenu.Items[1] as MenuItem).Visibility = (this.manager.StatusIndex[index] == (int)WorkshiftStatus.Pending) ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        private void cmSetAvailable_Click(object sender, RoutedEventArgs e) => this.manager.ChangeWorkshiftStatus(WorkshiftStatus.Available, (int)this.manager.SelectedWorkshiftIndex);
        private void cmSetUnvailable_Click(object sender, RoutedEventArgs e) => this.manager.ChangeWorkshiftStatus(WorkshiftStatus.Unavailable, (int)this.manager.SelectedWorkshiftIndex);
        private void cmClear_Click(object sender, RoutedEventArgs e) => this.manager.ClearWorkshifts((int)this.manager.SelectedWorkshiftIndex);

        private void cmApproveRequest_Click(object sender, RoutedEventArgs e)
        {
            if(this.manager.SelectedWorkshiftIndex != null)
            {
                int index = (int)this.manager.SelectedWorkshiftIndex;
                this.manager.ChangeWorkshiftStatus(WorkshiftStatus.Unavailable, index);
                RescheduleNotification selectedNotification = new RescheduleNotification(this.employee.UserID, this.date.Date, index);
                selectedNotification.RemoveNotification();
            }
        }

        private void cmDeclineRequest_Click(object sender, RoutedEventArgs e)
        {
            if (this.manager.SelectedWorkshiftIndex != null)
            {
                int index = (int)this.manager.SelectedWorkshiftIndex;
                this.manager.ChangeWorkshiftStatus(WorkshiftStatus.Available, index);
                RescheduleNotification selectedNotification = new RescheduleNotification(this.employee.UserID, this.date.Date, index);
                selectedNotification.RemoveNotification();
            }
        }

        private void cmRequestCancelation_Click(object sender, RoutedEventArgs e)
        {
            if (this.manager.SelectedWorkshiftIndex != null)
            {
                int index = (int)this.manager.SelectedWorkshiftIndex;
                this.manager.ChangeWorkshiftStatus(WorkshiftStatus.Pending, index);
                RescheduleNotification.AddNotification(this.employee.UserID, this.date, index);
            }
        }

        private void cmCancelCancelationRequest_Click(object sender, RoutedEventArgs e)
        {
            if (this.manager.SelectedWorkshiftIndex != null)
            {
                int index = (int)this.manager.SelectedWorkshiftIndex;
                this.manager.ChangeWorkshiftStatus(WorkshiftStatus.Available, index);
                RescheduleNotification selectedNotification = new RescheduleNotification(this.Employee.UserID, this.Date.Date, index);
                selectedNotification.RemoveNotification();
            }
        }
    }
}
