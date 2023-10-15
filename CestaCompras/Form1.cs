using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CestaCompras.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CestaCompras
{
    public partial class Form1 : Form
    {
        List<ItemCesta> cestaUm = new List<ItemCesta>();
        List<ItemCesta> cestaDois = new List<ItemCesta>();
        List<ItemCesta> cestaTres = new List<ItemCesta>();

        public Form1()
        {
            InitializeComponent();

            // Adiciona os itens da cesta 1
            cestaUm.Add(new ItemCesta { Nome = "Chocolate", Valor = 5.50m });
            cestaUm.Add(new ItemCesta { Nome = "Pão", Valor = 2.00m });
            cestaUm.Add(new ItemCesta { Nome = "Leite", Valor = 3.00m });
            cestaUm.Add(new ItemCesta { Nome = "Maçãs", Valor = 4.50m });
            cestaUm.Add(new ItemCesta { Nome = "Café", Valor = 6.20m });

            cestaDois.Add(new ItemCesta { Nome = "Queijo", Valor = 8.50m });
            cestaDois.Add(new ItemCesta { Nome = "Uvas", Valor = 6.00m });
            cestaDois.Add(new ItemCesta { Nome = "Iogurte", Valor = 2.75m });
            cestaDois.Add(new ItemCesta { Nome = "Biscoitos", Valor = 4.20m });
            cestaDois.Add(new ItemCesta { Nome = "Cereais", Valor = 3.75m });

            cestaTres.Add(new ItemCesta { Nome = "Frango", Valor = 10.75m });
            cestaTres.Add(new ItemCesta { Nome = "Arroz", Valor = 2.50m });
            cestaTres.Add(new ItemCesta { Nome = "Feijão", Valor = 3.25m });
            cestaTres.Add(new ItemCesta { Nome = "Cenouras", Valor = 1.80m });
            cestaTres.Add(new ItemCesta { Nome = "Água Mineral", Valor = 1.00m });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvListaItens.View = View.Details;
            lvListaItens.Columns.Add("Nome", 150);
            lvListaItens.Columns.Add("Valor", 150);
        }

        private void rdoCestaUm_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCestaUm.Checked)
            {
                CarregaItensCesta(cestaUm);
            }
        }

        private void rdoCestaDois_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCestaDois.Checked)
            {
                CarregaItensCesta(cestaDois);
            }
        }

        private void rdoCestaTres_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoCestaTres.Checked)
            {
                CarregaItensCesta(cestaTres);
            }
        }

        private void CarregaItensCesta(List<ItemCesta> lista)
        {
            lvListaItens.Items.Clear();

            foreach (var item in lista)
            {
                ListViewItem lvItem = new ListViewItem(item.Nome);
                lvItem.SubItems.Add(item.Valor.ToString("C"));

                lvListaItens.Items.Add(lvItem);
            }

            CalculaValorLista();
        }

        private void CalculaValorLista()
        {
            decimal total = 0;

            foreach(ListViewItem item in lvListaItens.Items)
            {
                decimal valorItem = decimal.Parse(
                    item.SubItems[1].Text, System.Globalization.NumberStyles.Currency
                );

                total += valorItem;
            }

            lblTotal.Text = total.ToString("C");
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você comprou a cesta!");
        }

        private void rdoMontarCesta_CheckedChanged(object sender, EventArgs e)
        {
            lvListaItens.Items.Clear();

            grpAdicionarItem.Visible = rdoMontarCesta.Checked;
        }

        private void ckbChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbChocolate.Checked)
            {
                AdicionarItemLista("Chocolate", 5.50m);
            }
            else
            {
                RemoverItemLista("Chocolate");
            }
        }

        private void AdicionarItemLista(string Nome, decimal Valor)
        {
            ListViewItem lvItem = new ListViewItem(Nome);
            lvItem.SubItems.Add(Valor.ToString("C"));

            lvListaItens.Items.Add(lvItem);

            CalculaValorLista();
        }

        private void RemoverItemLista(string Nome)
        {
            foreach (ListViewItem item in lvListaItens.Items)
            {
                if (item.Text == Nome)
                {
                    // Remova o item quando encontrar uma correspondência.
                    lvListaItens.Items.Remove(item);
                    break; // Encerre o loop, pois você já removeu o item desejado.
                }
            }

            CalculaValorLista();
        }
    }
}
