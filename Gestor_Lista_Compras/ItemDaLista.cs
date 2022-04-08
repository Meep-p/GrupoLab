using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor_Lista_Compras
{
    public class ItemDaLista
    {
        public int ID { get; set; }
        public string nomeItem { get; set; }
        public string categoria { get; set; }
        public string quantidade { get; set; }
        public bool stock { get; set; }
        public bool adiquirido { get; set; }    

        //metodos
        public void adicionarItemLista(int _ID, string _nomeItem, string _categoria, string _quantidade, bool _stock, bool _adiquirido )
        {
            ID = _ID;
            nomeItem = _nomeItem;
            categoria = _categoria;
            quantidade = _quantidade;
            stock = _stock;
            adiquirido = _adiquirido;
           
        }

        public void adicionarQuantidade(string _quantidade)
            {  quantidade += _quantidade; }


        public void adicionarItemCategoria()
        { }

        public void atualizarStock(bool _stock)
        {
            stock = _stock;
        }

        public void atualizarAdiquirido(bool _adiquirido)
        {
            adiquirido = _adiquirido;
        }
    }

}
