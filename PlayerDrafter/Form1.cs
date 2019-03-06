using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PlayerDrafter.Data;

namespace PlayerDrafter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new PlayerContext())
            {
                ProcessPlayerList()
                // Create and save a new Blog
                Console.Write("Enter a name for a new Blog: ");
                var name = Console.ReadLine();

                var blog = new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();
            }



            private static List<Player> ProcessPlayerList(string path)
            {
                var query =

                    File.ReadAllLines(path)
                        .Skip(1)
                        .Where(l => l.Length > 1)
                        .ToCar();

                return query.ToList();
            }
        }
}
