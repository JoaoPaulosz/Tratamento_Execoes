using System;

namespace Exercicio_Execoes.Entities.Exeptions {
    class DomainExeption : ApplicationException {

        public DomainExeption(string message) : base(message) {

            }

        }
    }
