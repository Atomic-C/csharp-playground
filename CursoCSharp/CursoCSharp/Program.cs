using System;
using System.Collections.Generic;
using CursoCSharp.ControlStructures;
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
                {"Lendo dados - Fundamentos", ReadingData.Execute },
                {"Formatando Números - Fundamentos", FormattingNumbers.Execute },
                {"Conversões - Fundamentos", Conversions.Execute },
                {"Operadores Aritméticos - Fundamentos", ArithmeticOperators.Execute },
                {"Operadores Relacionais - Fundamentos", RelationalOperators.Execute },
                {"Operadores Lógicos - Fundamentos", LogicalOperators.Execute },
                {"Operadores De Atribuição - Fundamentos", AttributionOperators.Execute },
                {"Operadores Unários - Fundamentos", UnaryOperators.Execute },
                {"Operadores Ternário - Fundamentos", TernaryOperator.Execute },
                // Control structures below
                {"Estrutura IF - Estruturas de Controlo", IfStructure.Execute },
                {"Estrutura IF Else - Estruturas de Controlo", IfElseStructure.Execute },
                {"Estrutura IF Else If - Estruturas de Controlo", IfElseIfStructure.Execute },
                {"Estrutura Switch - Estruturas de Controlo", SwitchStructure.Execute },
                {"Estrutura While - Estruturas de Controlo", WhileStructure.Execute },
            }) ;

            central.SelecionarEExecutar();
        }
    }
}