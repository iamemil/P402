using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21Apr18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            List<VirtualCard> vcards = new List<VirtualCard>();

            Card card1 = new Card("Emil Ismayilzada", "4197-8552-3820-8245","VISA",06,20,869,1000);
            cards.Add(card1);
            Card card2 = new Card("Emil Ismayilzada", "5148-9132-0584-7771", "MasterCard", 10, 21, 323, 1700);
            cards.Add(card2);


            string selectText = "";
            int select = 0;

            do
            {
                Console.WriteLine("1. Kartlarim");
                Console.WriteLine("2. Virtual Kartlarim");
                Console.WriteLine("3. Yeni Virtual Kart");
                Console.WriteLine("4. VirtuaL Kart Sil");
                Console.WriteLine("5. Xercle");
                Console.WriteLine("0. Cixis");


                Console.WriteLine("Seciminizi edin");
                selectText = Console.ReadLine();
                Console.WriteLine("===================================================================");
                while (!int.TryParse(selectText, out select))
                {
                    Console.WriteLine("Seciminiz reqem olmalidir");
                    selectText = Console.ReadLine();
                }
                switch (select)
                {
                    case 1:
                        int i = 1;
                        if (cards.Count > 0)
                        {                            
                            foreach (Card card in cards)
                            {
                                Console.WriteLine(i + ". Owner: " + card.CardOwner + "   Payment Processor: " + card.PaymentProcessor + "   Card Number: " + card.CardNumber + "   Expire Date: " + card.ExpireDate + "   VCC: " + card.VCC + "    Balance: " + card.Balance);
                                i++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sizin kartiniz yoxdur");
                        }
                        
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    case 2:
                        if (vcards.Count > 0)
                        {
                            i = 1;
                            foreach (VirtualCard vcard in vcards)
                            {
                                Console.WriteLine(i + ". Owner: " + cards[vcard.ParentCard].CardOwner + "   Payment Processor: " + cards[vcard.ParentCard].PaymentProcessor + "    Parent Card ID: " + vcard.ParentCard + "   Card Number: " + vcard.CardNumber + "   Expire Date: " + vcard.ExpireDate + "   VCC: " + vcard.VCC + "    Balance: " + vcard.Balance + "    Limit: " + vcard.Limit);
                                i++;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Sizin virtual kartiniz yoxdur");
                        }
                        
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    case 3:
                        if (cards.Count > 0)
                        {
                            i = 1;
                            foreach (Card card in cards)
                            {
                                Console.WriteLine(i + ". Owner: " + card.CardOwner + "   Payment Processor: " + card.PaymentProcessor + "   Card Number: " + card.CardNumber + "   Expire Date: " + card.ExpireDate + "   VCC: " + card.VCC + "    Balance: " + card.Balance);
                                i++;
                            }
                            Console.WriteLine("Virtual karti baglayacaginiz karti secin");
                            string inputCard = Console.ReadLine();
                            int inputCardint;
                            while (!int.TryParse(inputCard, out inputCardint))
                            {
                                Console.WriteLine("Seciminiz reqem olmalidir");
                                inputCard = Console.ReadLine();
                            }
                            inputCardint--;

                            Console.WriteLine("Bitis ayini daxil edin. 1-12");
                            string expireMonth = Console.ReadLine();
                            int expireMonthInt;
                            while (!int.TryParse(expireMonth, out expireMonthInt))
                            {
                                Console.WriteLine("Seciminiz reqem olmalidir 1-12");
                                expireMonth = Console.ReadLine();
                            }
                            if (expireMonthInt < 10)
                            {
                                expireMonth = "0" + expireMonthInt;
                            }
                            else
                            {
                                expireMonth = expireMonthInt.ToString();
                            }
                            Console.WriteLine("Bitis ilini daxil edin.");
                            string expireYear = Console.ReadLine();
                            int expireYearInt;
                            while (!int.TryParse(expireYear, out expireYearInt))
                            {
                                Console.WriteLine("Seciminiz reqem olmalidir 1-12");
                                expireYear = Console.ReadLine();
                            }
                            if (expireYearInt < 10)
                            {
                                expireYear = "0" + expireYearInt;
                            }
                            else
                            {
                                expireYear = expireYearInt.ToString();
                            }
                            Console.WriteLine("Limiti daxil edin daxil edin.");
                            string limit = Console.ReadLine();
                            double limitDouble;
                            while (!double.TryParse(limit, out limitDouble))
                            {
                                Console.WriteLine("Limit kesrli ve adi formatda olmalidir");
                                limit = Console.ReadLine();
                            }
                            if (cards[inputCardint].Balance <= limitDouble)
                            {
                                Console.WriteLine("Limit kart balansindan cox ola bilmez");
                            }
                            else
                            {
                                VirtualCard newVcard = new VirtualCard(inputCardint, expireMonth, expireYear, limitDouble);
                                vcards.Add(newVcard);
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Sizin kartiniz yoxdur");
                        }

                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    case 4:
                        if (vcards.Count > 0)
                        {
                            i = 1;
                            foreach (VirtualCard vcard in vcards)
                            {
                                Console.WriteLine(i + ". Owner: " + cards[vcard.ParentCard].CardOwner + "   Payment Processor: " + cards[vcard.ParentCard].PaymentProcessor + "    Parent Card ID: " + vcard.ParentCard + "   Card Number: " + vcard.CardNumber + "   Expire Date: " + vcard.ExpireDate + "   VCC: " + vcard.VCC + "    Balance: " + vcard.Balance + "    Limit: " + vcard.Limit);
                                i++;
                            }
                            Console.WriteLine("Sileceyiniz virtual karti secin");
                            string deleteCard = Console.ReadLine();
                            int deleteCardint;
                            while (!int.TryParse(deleteCard, out deleteCardint))
                            {
                                Console.WriteLine("Seciminiz reqem olmalidir");
                                deleteCard = Console.ReadLine();
                            }
                            deleteCardint--;

                            vcards.RemoveAt(deleteCardint);

                        }
                        else
                        {
                            Console.WriteLine("Sizin virtual kartiniz yoxdur");
                        }

                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    case 5:
                        if (vcards.Count > 0)
                        {
                            i = 1;
                            foreach (VirtualCard vcard in vcards)
                            {
                                Console.WriteLine(i + ". Owner: " + cards[vcard.ParentCard].CardOwner + "   Payment Processor: " + cards[vcard.ParentCard].PaymentProcessor + "    Parent Card ID: " + vcard.ParentCard + "   Card Number: " + vcard.CardNumber + "   Expire Date: " + vcard.ExpireDate + "   VCC: " + vcard.VCC + "    Balance: " + vcard.Balance + "    Limit: " + vcard.Limit);
                                i++;
                            }
                            Console.WriteLine("Xercleyeceyiniz virtual karti secin");
                            string deleteCard = Console.ReadLine();
                            int deleteCardint;
                            while (!int.TryParse(deleteCard, out deleteCardint))
                            {
                                Console.WriteLine("Seciminiz reqem olmalidir");
                                deleteCard = Console.ReadLine();
                            }
                            deleteCardint--;
                            Console.WriteLine("Xercleyeceyiniz meblegi daxil edin");
                            string fee = Console.ReadLine();
                            double feeDouble;
                            while (!double.TryParse(fee, out feeDouble))
                            {
                                Console.WriteLine("Meblegi duzgun daxil edin");
                                fee = Console.ReadLine();
                            }
                            if (vcards[deleteCardint].Balance >= feeDouble)
                            {
                                vcards[deleteCardint].Balance -= feeDouble;
                                Console.WriteLine(feeDouble+" xerclendi. "+ vcards[deleteCardint].Balance+" qeder pulunuz qaldi.");
                            }
                            else
                            {
                                Console.WriteLine("Balansinizda kifayet qeder pul yoxdur");
                            }
                            

                        }
                        else
                        {
                            Console.WriteLine("Sizin virtual kartiniz yoxdur");
                        }

                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Secimleriniz 1,2,3,4 ve ya 5 ola biler");
                        Console.WriteLine("===================================================================");
                        Console.WriteLine("");
                        break;
                }
            } while (select != 0);
        }
    }
}
