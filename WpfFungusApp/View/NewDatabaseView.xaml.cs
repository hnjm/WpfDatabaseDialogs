﻿using System.Windows;

namespace WpfFungusApp.View
{
    /// <summary>
    /// Interaction logic for SqlConnectionDialog.xaml
    /// </summary>
    public partial class NewDatabaseView : Window
    {
        public NewDatabaseView()
        {
            InitializeComponent();
        }

        private void _buttonRefresh_Click(object sender, RoutedEventArgs e)
        {
            ViewModel.NewDatabaseViewModel sqlConnectionViewModel = DataContext as ViewModel.NewDatabaseViewModel;
            sqlConnectionViewModel.Refresh();
        }

        private void _buttonBrowseMicrosoftSQLServerFolders_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog == null)
            {
                return;
            }

            ViewModel.NewDatabaseViewModel newDatabaseViewModel = DataContext as ViewModel.NewDatabaseViewModel;
            dialog.SelectedPath = newDatabaseViewModel.SQLServer_Folder;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                newDatabaseViewModel.SQLServer_Folder = dialog.SelectedPath;
            }
        }

        private void _buttonBrowseSQLiteFolders_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog == null)
            {
                return;
            }

            ViewModel.NewDatabaseViewModel sqlConnectionViewModel = DataContext as ViewModel.NewDatabaseViewModel;
            dialog.SelectedPath = sqlConnectionViewModel.SQLite_Folder;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sqlConnectionViewModel.SQLite_Folder = dialog.SelectedPath;
            }
        }

        private void _buttonOK_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        private void _buttonCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
