using System;
using System.Data;

namespace ExeSQL
{
    public class ExecProcedures
    {
        public ExecProcedures(string constr)
        {
            
        }

        public ExecProcedures(string constr, string path)
        {
            
        }

        public bool Get(string storproc)
        {
            return false;
        }

        public bool Get(string[] namesparams, string[] valuesparams, string storproc)
        {
            return false;
        }

        public bool GetM(string storproc)
        {
            return false;
        }

        public bool GetM(string[] namesparams, string[] valuesparams, string storproc)
        {
            return false;
        }

        public bool GetSet(string[] namesparams, string[] valuesparams, string storproc)
        {
            return false;
        }

        public bool GetSetM(string[] namesparams, string[] valuesparams, string storproc)
        {
            return false;
        }

        public bool Set(string storproc)
        {
            return false;
        }

        public bool Set(string[] namesparams, string[] valuesparams, string storproc)
        {
            return false;
        }
    }
}