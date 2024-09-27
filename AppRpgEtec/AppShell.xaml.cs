﻿using AppRpgEtec.Views.Personagens;

namespace AppRpgEtec
{
    public partial class AppShell : Shell
    {
        private CadastroPersonagemView viewModel;

        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("cadPersonagemView", typeof(CadastroPersonagemView));
           // Routing.RegisterRoute("ListagemView", typeof(ListagemView));

            //viewModel = new AppShellViewModel();
            //BindingContext = viewModel;
        }
    }
}