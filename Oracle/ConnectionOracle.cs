using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ExeSQL
{
    class ConnectionOracle
    {
        
        public ConnectionOracle(string str)
        {
            
        }

        public ConnectionOracle(string str, string path)
        {
            
        }

        private bool Abrir()
        {
            return false;
        }

        private bool Cerrar()
        {
            return false;
        }

        public bool EjecutaStoreProcedure(string nomSProcedure)
        {
            return false;
        }

        public bool EjecutaStoreProcedure(string nomSProcedure, Parameter[] datos)
        {
            return false;
        }

        public bool EjecutaStoreProcedureIO(string nomSProcedure, Parameter[] datos)
        {
            return false;
        }

        public bool EjecutaStoreProcedureMIO(string nomSProcedure, Parameter[] datos)
        {
            return false;
        }

        public bool GetDatosSP(string nameProcedure)
        {
            return false;
        }

        public bool GetDatosMSP(string nameProcedure)
        {
            return false;
        }

        public bool GetDatosSP(string nameProcedure, Parameter[] datos)
        {
            return false;
        }

        public bool GetDatosMSP(string nameProcedure, Parameter[] datos)
        {
            return false;
        }

        private List<string> GetOuts(string nameProcedure)
        {
            List<string> paramts = new List<string>();
            return paramts;
        }

        private Type GetType(string name)
        {
            return null;
        }
    }
}