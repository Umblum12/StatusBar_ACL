using System;
using System.Collections.Generic;
using System.Text;

namespace StatusBar_ACL.VistaModelo
{
    public interface VMstatusbar
    {
        void OcultarStatusBar();
        void MostrarStatusBar();
        void Traslucido();
        void Transparente();
        void CambiarColor();
    }
}
