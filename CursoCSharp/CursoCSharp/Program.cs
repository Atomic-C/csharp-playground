using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentals;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", FirstProgram.Execute}, // I register the exercises
                {"Commentários - Fundamentos",Coments.Execute },
                {"Variáveis e Constantes - Fundamentos", VariablesAndConstants.Execute },
                {"Inferência - Fundamentos", Inference.Execute },
                {"Interpolação - Fundamentos", Interpolation.Execute },
                {"Dot Notation - Fundamentos", DotNotation.Execute },
            }) ;

            central.SelecionarEExecutar();
        }
    }
}