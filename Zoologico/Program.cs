using System;
using System.Linq;
using Zoologico.Interfaces;
using Zoologico.Models.Animais;

namespace Zoologico {
    class Program {
        static void Main (string[] args) {
            var encerrouPrograma = false;
            do {
                #region Menu Principal
                var codigo = 0;
                Console.Clear ();
                System.Console.WriteLine ("===============================");
                System.Console.WriteLine ("|  Bem- vindo ao Zoo Lógico!  |");
                System.Console.WriteLine ("===============================");

                System.Console.WriteLine ("O que deseja fazer ? ");
                System.Console.WriteLine ("1 - Alocar animal manualmente");
                System.Console.WriteLine ("2 - Alocar animal automaticamente");
                string opçao = Console.ReadLine ();

                Animal Feltrim = new Animal("Branca", 18);

                switch (opçao) {
                    case "1":
                    foreach (var item in Arca.Animais.Values) {
                            System.Console.WriteLine ($"{" ",5}{++codigo}. {item.GetType().Name}");
                        }
                        #endregion

                        System.Console.Write ($"\n{" ",2}Digite o código do animal: ");

                        // Testando se o usuário digitou um código correto ou não
                        try {
                            var opcaoUsuario = int.Parse (Console.ReadLine ());
                            var animal = Arca.Animais[opcaoUsuario];
                            ClassificarAnimal (animal);
                        } catch (Exception) {
                            System.Console.WriteLine ("Por favor, digite um código válido");
                            Console.ReadLine ();

                        }
                        break;

                    case "2":

                        foreach (var item in Arca.Animais.Values) {
                            System.Console.WriteLine ($"{" ",5}{++codigo}. {item.GetType().Name}");
                        }
                        

                        System.Console.Write ($"\n{" ",2}Digite o código do animal: ");

                        // Testando se o usuário digitou um código correto ou não
                        try {
                            var opcaoUsuario = int.Parse (Console.ReadLine ());
                            var animal = Arca.Animais[opcaoUsuario];
                            ClassificarAnimal (animal);
                        } catch (Exception) {
                            System.Console.WriteLine ("Por favor, digite um código válido");
                            Console.ReadLine ();

                        }
                        break;

                }

            } while (!encerrouPrograma);

        }
        public static void ClassificarAnimal (Animal animal) {

            var classe = animal.GetType ();
            var @interface = classe.GetInterfaces ().FirstOrDefault ();

            if ((typeof (IAquatico)).Equals (@interface)) {
                System.Console.WriteLine ($":::{classe.Name} pode ir para a Piscina:::");
            } else if ((typeof (IArboricula)).Equals (@interface)) {
                System.Console.WriteLine ($":::{classe.Name} pode ir para a Casa na Árvore:::");
            } else if ((typeof (IBranquiado)).Equals (@interface)) {
                System.Console.WriteLine ($":::{classe.Name} pode ir para o Aquário:::");
            } else if ((typeof (IQuionofilo)).Equals (@interface)) {
                System.Console.WriteLine ($":::{classe.Name} pode ir  para a Piscina Gelada:::");
            } else if ((typeof (ITerrestre)).Equals (@interface)) {
                System.Console.WriteLine ($":::{classe.Name} pode ir para os Pastos ou Caverna de Pedra:::");
            } else if ((typeof (IVoador)).Equals (@interface)) {
                System.Console.WriteLine ($":::{classe.Name} pode ir para a Gaiola:::");
            }

            Console.ReadLine ();

        }

        public static void ClassificarManual(Animal animal){

        }

        /*alocar animal

        qual animal deseja alocar
        em que jaula 
         */
    }
}