using Calidad20222.web.Controllers;
using Calidad20222.web.Helper;
using Calidad20222.web.Models;
using Calidad20222.web.Services;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalidadF
{
    
    public class Tester1
    {
        PokerService pokerService;
        [Test]
        public void CartaMayor01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 1,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 10,
                    Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 7,
                    Palo = "CORAZON"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("CARTA MAYOR", resultado);
        }

        [Test]
        public void CartaMayor02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 7,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 3,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 2,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 4,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 6,
                    Palo = "ESPADA"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("CARTA MAYOR", resultado);
        }

        [Test]
        public void Doble01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 7,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 7,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 6,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 5,
                    Palo = "COCO"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("DOBLE", resultado);
        }

        [Test]
        public void Doble02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 13,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 6,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 1,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 6,
                    Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "COCO"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("DOBLE", resultado);
        }

        [Test]
        public void Colo01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 7,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 1,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 2,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "TREBOL"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("COLOR", resultado);
        }

        [Test]
        public void Colo02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 13,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 3,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 12,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 7,
                    Palo = "CORAZON"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("COLOR", resultado);
        }

        [Test]
        public void Poker01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 11,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 1,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "CORAZON"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("POKER", resultado);
        }

        [Test]
        public void Poker02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 5,
                    Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 5,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 5,
                    Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 5,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "CORAZON"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("POKER", resultado);
        }

        [Test]
        public void EscaleraColor01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 10,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 9,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 7,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 6,
                    Palo = "COCO"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA DE COLOR", resultado);
        }

        [Test]
        public void EscaleraColor02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 1,
                    Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 4,
                    Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 5,
                    Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 2,
                    Palo = "ESPADA"
                },
                new Carta()
                {
                    Numero = 3,
                    Palo = "ESPADA"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA DE COLOR", resultado);
        }

        [Test]
        public void EscaleraReal01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 1,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 12,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 13,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 10,
                    Palo = "COCO"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA REAL", resultado);
        }

        [Test]
        public void EscaleraReal02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 1,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 12,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 13,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 10,
                    Palo = "CORAZON"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA REAL", resultado);
        }

        [Test]
        public void DoblePareja01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 11,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 12,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 12,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 7,
                    Palo = "COCO"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("DOBLE PAREJA", resultado);
        }

        [Test]
        public void DoblePareja02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 10,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 10,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "COCO"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("DOBLE PAREJA", resultado);
        }

        [Test]
        public void Trio01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 11,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "ESPADAS"
                },
                
                new Carta()
                {
                    Numero = 6,
                    Palo = "CORAZON"
                }               
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("TRIO", resultado);
        }

        [Test]
        public void Trio02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 7,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 5,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 7,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 8,
                    Palo = "CORAZON"
                },             
                new Carta()
                {
                    Numero = 7,
                    Palo = "CORAZON"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("TRIO", resultado);
        }

        [Test]
        public void Full01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 7,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 7,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 7,
                    Palo = "TREBOL"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("FULL", resultado);
        }

        [Test]
        public void Full02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 12,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 13,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 12,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 13,
                    Palo = "COCO"
                },
                new Carta()
                {
                    Numero = 12,
                    Palo = "COCO"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("FULL", resultado);
        }

        [Test]
        public void Escalera01()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 1,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 3,
                    Palo = "ESPADAS"
                    
                },
                new Carta()
                {
                    Numero = 2,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 5,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 4,
                    Palo = "COCO"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA", resultado);
        }

        [Test]
        public void Escalera02()
        {
            List<Carta> cartaList = new List<Carta>()
            {
                new Carta()
                {
                    Numero = 10,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 12,
                    Palo = "CORAZON"
                },
                new Carta()
                {
                    Numero = 11,
                    Palo = "ESPADAS"
                },
                new Carta()
                {
                    Numero = 9,
                    Palo = "TREBOL"
                },
                new Carta()
                {
                    Numero = 13,
                    Palo = "COCO"
                }
            };

            pokerService = new PokerService();
            var resultado = pokerService.GetJugada(cartaList);
            Assert.AreEqual("ESCALERA", resultado);
        }
    }
}
