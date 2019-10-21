using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Data;


namespace WinForms
{
    public partial class UserControl1: UserControl
    {
        public Loja Loja { get; private set; }
        private ProductDbContext context = new ProductDbContext();
        public UserControl1()
        {
            InitializeComponent();

            context = new ProductDbContext();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja()
            {
                Nome = "Loja teste"
            };
            context.Lojas.Add(loja);

            Produto produto = new Produto()
            {
                Nome = "Produto teste",
                Valor = Convert.ToInt32(20m),
                Loja = loja
            };
            context.Produtos.Add(produto);

            context.SaveChanges();
        }
    }
}
