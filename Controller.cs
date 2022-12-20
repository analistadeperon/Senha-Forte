private void txtSenha_TextChanged(object sender, EventArgs e)
        {
            if (txtSenha.Text != string.Empty)
            {
                ChecaForcaSenha verifica = new ChecaForcaSenha();
                int placar;
                ForcaDaSenha forca;

                placar = verifica.geraPontosSenha(txtSenha.Text);
                forca = verifica.GetForcaDaSenha(txtSenha.Text);

                lblPontosSenha.Text = placar.ToString() + " Pontos";
                lblForcaSenha.Text = forca.ToString();
            }
        }
