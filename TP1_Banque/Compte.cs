using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Banque
{
    class Compte
    {
        private int numero;
        private string nomProprio;
        private int solde;
        private int montantDecouvert;

        public Compte(int numero, string nomProprio, int solde, int montantDecouvert)
        {
            this.numero = numero;
            this.nomProprio = nomProprio;
            this.solde = solde;
            this.montantDecouvert = montantDecouvert;
        }

        public Compte()
        {
            this.numero = 0;
            this.nomProprio = "";
            this.solde = 0;
            this.montantDecouvert = 0;
        }

        public int lesolde()
        {
            return this.solde;
        }

        public int crediter(int somme)
        {
            this.solde = this.solde + somme;
            return this.solde;
        }

        public bool debiter(int montantDebit)
        {
            if ((this.solde + this.montantDecouvert * -1) < montantDebit)
            {
                if (this.solde >= montantDebit)
                {
                    this.solde = this.solde - montantDebit;
                    return true;
                }
                else
                {
                    this.montantDecouvert = this.montantDecouvert - (montantDebit - this.solde);
                    this.solde = 0;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool transferer(int montantTransfert)
        {
            if ((this.solde + this.montantDecouvert * -1) < montantTransfert)
            {
                if (this.solde >= montantTransfert)
                {
                    this.solde = this.solde - montantTransfert;
                    return true;
                }
                else
                {
                    this.montantDecouvert = this.montantDecouvert - (montantTransfert - this.solde);
                    this.solde = 0;
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Numéro : " + this.numero + Environment.NewLine + "nom : " + this.nomProprio + Environment.NewLine + "Solde : " + this.solde + Environment.NewLine + "Découvert autorisé " + this.montantDecouvert;

        }


    }
}
