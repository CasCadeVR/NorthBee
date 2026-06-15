using System;
using System.Windows.Forms;
using NorthBee.Desktop.Forms;
using NorthBee.Desktop.Models;

namespace NorthBee.Desktop
{
    internal static class Program
    {
        /// <summary>
        /// PKGH
        /// Контекст базы данных
        /// </summary>
        public static NorthBeeDbContext Context = new NorthBeeDbContext();

        /// <summary>
        /// PKGH
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!Context.Database.Exists())
            {
                MessageBox.Show("Ошибка подключения к базе данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
