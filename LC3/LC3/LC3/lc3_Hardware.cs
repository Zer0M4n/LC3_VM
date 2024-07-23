using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LC3
{
    public class lc3_Hardware
    {

        //Registers

        public enum Register
        {
            R_R0 = 0,
            R_R1 ,
            R_R2 ,
            R_R3 ,
            R_R4 ,
            R_R5 ,
            R_R6 ,
            R_R7 ,
            R_PC ,//Program counter
            R_COUND,
            R_COUNT,
        };

        //Opcodes
        public enum Opcodes
        {
            OP_BR = 0, // branch
            OP_ADD,    // add  
            OP_LD,     // load 
            OP_ST,     // store 
            OP_JSR,    // jump register 
            OP_AND,    // bitwise and 
            OP_LDR,    // load register 
            OP_STR,    // store register 
            OP_RTI,    // unused 
            OP_NOT,    // bitwise not 
            OP_LDI,    // load indirect 
            OP_STI,    // store indirect 
            OP_JMP,    // jump 
            OP_RES,    // reserved (unused)
            OP_LEA,    // load effective address
            OP_TRAP    // execute trap
        };
    }
}
