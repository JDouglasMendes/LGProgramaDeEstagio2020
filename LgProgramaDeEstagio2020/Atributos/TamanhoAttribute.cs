using System;

namespace LgProgramaDeEstagio2020
{
    public class TamanhoAttribute : Attribute
    {
        public int v1 { }
        public int v2;

        public TamanhoAttribute(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}