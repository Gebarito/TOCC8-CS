using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOCC8_PDV
{
    public partial class FMain : Form
    { 
        public FMain()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
            produto p;
            string msg = "";

            try
            {
                p = new produto();

                p.descricao = txtDescricao.Text;
                p.preco = Convert.ToDouble(txtPreco.Text);
                p.taxalucro = Convert.ToDouble(txtTaxaLucro.Text);
                p.datavalidade = Convert.ToDateTime(dtpDataValidade.Text);

                contexto = new TOCC8Entities();
                contexto.produto.Add(p);
                contexto.SaveChanges();
                msg = "Produto cadastrado com sucesso!";
            }
            catch (Exception ex)
            {
                msg = "Erro ao cadastrar produto: " + ex.Message;
            }
            finally
            {
                MessageBox.Show(msg, "Cadastro de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAndFocus();
                this.btnListar.PerformClick();
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            TOCC8Entities contexto;

            try
            {
                contexto = new TOCC8Entities();
                var produtos = from c in contexto.produto select c;
                this.dgvProduto.DataSource = produtos.ToList();
            }
            catch (Exception) { throw; }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
            produto p;
            int codigo;
            string msg = "";

            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
                contexto = new TOCC8Entities();
                p = contexto.produto.First(c => c.codigo == codigo);

                if (p != null)
                {
                    p.descricao = txtDescricao.Text;
                    p.preco = Convert.ToDouble(txtPreco.Text);
                    p.taxalucro = Convert.ToDouble(txtTaxaLucro.Text);
                    p.datavalidade = Convert.ToDateTime(dtpDataValidade.Text);
                    contexto.SaveChanges();
                    msg = "Produto atualizado com sucesso!";
                }
                this.btnListar.PerformClick();
            }
            catch (Exception ex)
            {
                msg = "Erro ao atualizar produto: " + ex.Message;
            }
            finally
            {
                MessageBox.Show(msg, "Atualização de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAndFocus();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
            produto p;
            int codigo;
            string msg = "";

            try
            {
                codigo = Convert.ToInt32(txtCodigo.Text);
                contexto = new TOCC8Entities();
                p = contexto.produto.First(c => c.codigo == codigo);
                if (p != null)
                {
                    contexto.produto.Remove(p);
                    contexto.SaveChanges();
                    msg = "Produto removido com sucesso!";
                    this.btnListar.PerformClick();
                }
            }
            catch(Exception ex) 
            {
                msg = "Erro ao remover produto: " + ex.Message;
            }
            finally
            {
                MessageBox.Show(msg, "Remoção de Produto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearAndFocus();
            }

        }

        private void btnGrafico_Click(object sender, EventArgs e)
        {
            FGrafico f = new FGrafico();
            f.WindowState = FormWindowState.Maximized;
            f.ShowDialog();
        }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int linha;
            linha = this.dgvProduto.SelectedCells[0].RowIndex;
            this.txtCodigo.Text = dgvProduto.Rows[linha].Cells[0].Value.ToString();
            this.txtDescricao.Text = dgvProduto.Rows[linha].Cells[1].Value.ToString();
            this.dtpDataValidade.Text = dgvProduto.Rows[linha].Cells[2].Value.ToString();
            this.txtPreco.Text = dgvProduto.Rows[linha].Cells[3].Value.ToString();
            this.txtTaxaLucro.Text = dgvProduto.Rows[linha].Cells[4].Value.ToString();
            this.txtPrazoValidade.Text = (Convert.ToDateTime(dtpDataValidade.Text) - DateTime.Now).Days.ToString() + " dias";
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            TOCC8Entities contexto;
            produto p;
            int codigo;

            try
            {
                if (this.txtCodigo.Text.Trim().Length > 0)
                {
                    codigo = Convert.ToInt32(txtCodigo.Text);
                    contexto = new TOCC8Entities();
                    p = contexto.produto.First(c => c.codigo == codigo);

                    if (p != null)
                    {
                        this.txtCodigo.Text = p.codigo.ToString();
                        this.txtDescricao.Text = p.descricao;
                        this.txtPreco.Text = p.preco.ToString();
                        this.txtTaxaLucro.Text = p.taxalucro.ToString();
                        this.dtpDataValidade.Text = p.datavalidade.ToString();
                        this.txtPrazoValidade.Text = (Convert.ToDateTime(dtpDataValidade.Text) - DateTime.Now).Days.ToString() + " dias";
                    }
                    else
                    {
                        this.txtDescricao.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtDescricao_KeyUp(object sender, KeyEventArgs e)
        {
            TOCC8Entities contexto;

            try
            {
                contexto = new TOCC8Entities();
                var produtos = contexto.produto.Where(c => c.descricao.StartsWith(txtDescricao.Text.ToLower()));
                this.dgvProduto.DataSource = produtos.ToList();
            }
            catch (Exception) { throw; }
        }
        
        private void ClearAndFocus()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtPreco.Clear();
            txtTaxaLucro.Clear();
            txtPrazoValidade.Clear();
            dtpDataValidade.Value = DateTime.Now;
            txtCodigo.Focus();
        }
    }

}
