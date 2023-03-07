using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Ежедневник
{
    internal class Decicions : ICRUD
    {
        List<Info> Zametki = new List<Info>();
        public void Create()
        {
            MainWindow main = new MainWindow();
            Zametki.Add(new Info(
                        Convert.ToDateTime(main.Date.SelectedDate),
                        main.Maintxt.Text,
                        main.Sectxt.Text
                        ));
            SaveIt.MySerialyze(Zametki);
        }

        public List<Info> Read()
        {
            Zametki = SaveIt.MyDeserialize<List<Info>>();
            return Zametki;
        }

        public void Update()
        {
            MainWindow main = new MainWindow();
            Zametki[main.LBox.SelectedIndex] = new Info(
                Convert.ToDateTime(main.Date.SelectedDate),
                        main.Maintxt.Text,
                        main.Sectxt.Text
                );
        }

        public void Delete()
        {
            MainWindow main = new MainWindow();
            List<Info> dop = Read();
            Zametki.Clear();
            for (int i = 0; i < dop.Count; i++)
            {
                if (i == main.LBox.SelectedIndex)
                {
                    continue;
                }
                Zametki.Add(dop[i]);
            }
        }
    }
}
