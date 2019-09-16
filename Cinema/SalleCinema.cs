using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    public class SalleCinema
    {
        private string titre;
        private int nmbPlace;
        private double prixUnitaire;
        private int nmbPlaceTarifN = 0;
        private int nmbPlaceTarifR = 0;

        public SalleCinema(string unTitre, int unNmbPLace, double unPrixUnitaire)
        {
            this.titre = unTitre;
            this.nmbPlace = unNmbPLace;
            this.prixUnitaire = unPrixUnitaire;
        }

        public string getTitre()
        {
            return titre;
        }

        public int getNmbPlace()
        {
            return nmbPlace;
        }

        public double getPrixUnitaire()
        {
            return prixUnitaire;
        }

        public int getNmbPlaceTarifN()
        {
            return nmbPlaceTarifN;
        }

        public int getNmbPlaceTarifR()
        {
            return nmbPlaceTarifR;
        }

        public int nbPlacesDisponibles()
        {
            int placeDispo = nmbPlace - (nmbPlaceTarifN + nmbPlaceTarifR);
            return placeDispo;
        }
        

    } 
}
