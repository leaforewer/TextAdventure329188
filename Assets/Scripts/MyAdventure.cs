using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAdventure : MonoBehaviour
{
    private enum States //BIJ HIER DE '1' EN '2' NUMMERS BEPALEN DE SITUATIE MET NOTIFICATIE OF ZONDER NOTIFICATIE
    {
        mainmenu,
        start,
        verhaal,
        verderverhaal,
        meldingen,
        meldnee,
        meldja,
        informatiecomputer1,
        informatiecomputer2,
        hackrequest1,
        hackrequest2,
        hackja1,
        hackja2,
        meldingbitcoin1, //wifi suggestion here
        meldingbitcoin2, //gaat naar swat
        wifija,
        wifinee,
        swats,
        swatsend,
        requests1,
        requests2,
        deepwebnot1, //deepweb
        deepwebsurf1,
        deepwebsurf1v,
        deepwebsituatie,
        deepwebpizza,
        deepwebeye,
        deepwebkeuze2,
        deepwebpeek,
        deepwebnopeek,
        deepwebkeuze3,
        deepwebtaser,
        deepwebdoorbell,
        deepwebsurf2,
        hitman2,
        quit1,
        quit2,
        quitja1,
        quitja2,
    }

    private States currentState = States.start;

    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    void ShowMainMenu()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Welcome to Last Work");
        Terminal.WriteLine("This is a Text-Based game and you must   ensure that you make good choices.");
        Terminal.WriteLine("Every decision you make can change has consequences, be careful.");
        Terminal.WriteLine("                                       ");
        Terminal.WriteLine("Type start to begin");
        currentState = States.mainmenu;
    }

    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.mainmenu:
                if (input == "start")
                {
                    Startverhaal();
                }

                break;
            //verhaal
            case States.verhaal:
                if (input == "verder")
                {
                    Verderverhaal();
                }

                break;
            case States.verderverhaal:
                if (input == "notification")
                {
                    Meldingen();
                }

                break;
            //Meldingen
            case States.meldingen:

                if (input == "1")
                {
                    Meldja();
                }

                else if (input == "2")
                {
                    Meldnee();
                }

                break;

            //meld ja
            case States.meldja:

                if (input == "info.cmp")
                {
                    Informatiecomputer1();
                }

                break;

            //meld nee
            case States.meldnee:

                if (input == "info.cmp")
                {
                    Informatiecomputer2();
                }

                break;

            //Hackrequest with notifocation
            case States.informatiecomputer1:
                if (input == "continue")
                {
                    Hacrequest1();
                }

                break;
            //Hackrequest with no notification
            case States.informatiecomputer2:
                if (input == "continue")
                {
                    Hacrequest2();
                }

                break;

            //Hackrequest noti
            case States.hackrequest1:
                if (input == "yes")
                {
                    Hackja1();
                }
                else if (input == "no")
                {
                    Requests1();
                }

                break;
            //Hackrequest no noti
            case States.hackrequest2:
                if (input == "yes")
                {
                    Hackja2();
                }
                else if (input == "no")
                {
                    Requests2();
                }

                break;
            //Hackja
            case States.hackja1:
                if (input == "dascoin")
                {
                    Meldingbitcoin1();
                }

                break;
            //Noti van wifi veranderen
            case States.meldingbitcoin1:
                if (input == "yes")
                {
                    Wifichange();
                }
                else if (input == "no")
                {
                    Wifinochange();
                }

                break;
            //Request menu
            case States.wifija:
                if (input == "request")
                {
                    Requests1();
                }

                break;

            //gelinkd naar de eind van fbi
            case States.wifinee:
                if (input == "request")
                {
                    Swats();
                }

                break;
            case States.hackja2:
                if (input == "dascoin")
                {
                    Meldingbitcoin2();
                }

                break;
            case States.meldingbitcoin2:

                if (input == "request")
                {
                    Swats();
                }

                break;
            case States.swats:
                if (input == "silence")
                {
                    Swatsend();
                }

                break;
            case States.swatsend:
                if (input == "mainmenu")
                {
                    ShowMainMenu();
                }

                break;

            //Hacknee with noti
            case States.requests1:
                if (input == "Deepweb")
                {
                    Deepwebnot1();
                }
                else if (input == "Hack")
                {
                    Hacrequest1();
                }
                else if (input == "Quit")
                {
                    Quit1();
                }

                break;
            case States.deepwebnot1:
                if (input == "continue")
                {
                    Deepwebsurf1();
                }

                break;

            case States.deepwebsurf1:
                if (input == "v")
                {
                    Deepwebsurf1v();
                }

                break;
            case States.deepwebsurf1v:
                if (input == "surf")
                {
                    Deepwebsituatie();
                }

                break;
            case States.deepwebsituatie:
                if (input == "pizza")
                {
                    Deepwebpizza();
                }

                break;
            case States.deepwebpizza:
                if (input == "door")
                {
                    Deepwebeye();
                }
                else if (input == "closet")
                {
                    Deepwebkeuze2();
                }

                break;
            case States.deepwebeye:
                if (input == "mainmenu")
                {
                    ShowMainMenu();
                }

                break;
            case States.deepwebkeuze2:
                if (input == "peek")
                {
                    Deepwebpeek();
                }
                else if (input == "stay")
                {
                    Deepwebnopeek();
                }

                break;
            case States.deepwebpeek:
                if (input == "mainmenu")
                {
                    ShowMainMenu();
                }

                break;
            case States.deepwebnopeek:
                if (input == "taser")
                {
                    Deepwebtaser();
                }
                else if (input == "stay")
                {
                    Deepwebdoorbell();
                }

                break;
            //Hacknee with no noti
            case States.requests2:
                if (input == "Deepweb")
                {
                    Deepwebsurf2();
                }
                else if (input == "Hack")
                {
                    Hacrequest2();
                }
                else if (input == "Quit")
                {
                    Quit2();
                }

                break;
            case States.deepwebsurf2:
                if (input == "continue")
                {
                    Deepwebhitman2();
                }

                break;
            case States.hitman2:
                if (input == "mainmenu")
                {
                    ShowMainMenu();
                }

                break;

            //Hier wil ik dat player in zelfde nummer blijft 1 of 2. Ook in quit section.
            case States.quit1:
                if (input == "yes")
                {
                    Quitja1();
                }
                else if (input == "no")
                {
                    Requests1();
                }

                break;
            case States.quit2:
                if (input == "yes")
                {
                    Quitja2();
                }
                else if (input == "no")
                {
                    Requests2();
                }

                break;
            case States.quitja1:
                if (input == "mainmenu")
                {
                    ShowMainMenu();
                }

                break;
            case States.quitja2:
                if (input == "mainmenu")
                {
                    ShowMainMenu();
                }

                break;
        }
    }


    void Startverhaal()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("It's Friday night, and it's the   last hour of your work");
        Terminal.WriteLine("You are happy that you go home after a hour and enjoy chilling, playing games   and more!");
        Terminal.WriteLine("But you hear a noise in a room that you never entered.");
        Terminal.WriteLine("                                        ");
        Terminal.WriteLine("Type 'verder' to continue ..");
        currentState = States.verhaal;
    }

    void Verderverhaal()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You go to the room and you see that the computer is on");
        Terminal.WriteLine("You sit in front of the computer and you see something happen.");
        Terminal.WriteLine("                                           ");
        Terminal.WriteLine("Oh, it was just a notification, type   'notification' to see notification.");
        currentState = States.verderverhaal;
    }

    void Meldingen()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You receive a notification to    always turn on the computer's notification.");
        Terminal.WriteLine("Do you want to do this?");
        Terminal.WriteLine("                                         ");
        Terminal.WriteLine("Type '1' to accept or type '2' to not  accept");
        currentState = States.meldingen;
    }

    void Meldja()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Notifications are now on.");
        Terminal.WriteLine("Hello, it's Floeran. I am the best capable computer ever in this computer hell.");
        Terminal.WriteLine("Well, If you want more information    about me,");
        Terminal.WriteLine("Type 'info.cmp' to get information.");
        currentState = States.meldja;
    }

    void Meldnee()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello, it's Floeran. I am the best capable computer ever in this computer hell.");
        Terminal.WriteLine("Well, If you want more information    about me,");
        Terminal.WriteLine("Type 'info.cmp' to get information.");
        currentState = States.meldnee;
    }

    void Informatiecomputer1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Information:");
        Terminal.WriteLine(" Made in Germany" +
                           "                    " +
                           "                     " +
                           " Last log : 18/09/1890" +
                           "                " +
                           "                       " +
                           " Specification:" +
                           "                     " +
                           "                     " +
                           " Illegal money transfer" +
                           "                 " +
                           " Access to the Deepweb" +
                           "                 " +
                           "                         " +
                           "Type 'continue' to go further");
        currentState = States.informatiecomputer1;
    }

    void Informatiecomputer2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Information:");
        Terminal.WriteLine(" Made in Germany" +
                           "                    " +
                           "                     " +
                           " Last log : 18/09/1890" +
                           "                " +
                           "                       " +
                           " Specification:" +
                           "                     " +
                           "                     " +
                           " Illegal money transfer" +
                           "                 " +
                           " Access to the Deepweb" +
                           "                 " +
                           "                         " +
                           "Type 'continue' to go further");
        currentState = States.informatiecomputer2;
    }

    //HACK SECTION
    void Hacrequest1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("A mean while later there comes suggestion from computer and it says" +
                           "'Do you want to get rid of your work and live the rest of your life with pleasent?" +
                           " Then, we can hack somebody to gain money from him. But it's a risky process, there may be some people who can track us, like swat or fbi..." +
                           "Are you sure you want to do this ?'" +
                           "                   ");
        Terminal.WriteLine("Type 'yes' to accept the suggestion or Type 'no' to reject the suggestion.");
        currentState = States.hackrequest1;
    }

    void Hacrequest2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("A mean while later there comes suggestion from computer and it says" +
                           "'Do you want to get rid of your work and live the rest of your life with pleasent?" +
                           " Then, we can hack somebody to gain money from him. But it's a risky process, there may be some people who can track us, like swat or fbi..." +
                           "Are you sure you want to do this ?'" +
                           "                   ");
        Terminal.WriteLine("Type 'yes' to accept the suggestion or Type 'no' to reject the suggestion.");
        currentState = States.hackrequest2;
    }

    void Hackja1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Florean opens the software which it    uses for hacking the people" +
                           "             ---------------Proccessing---------------" +
                           "---------------Cracking-----------------------" +
                           "--------------------------------------------------" +
                           " Done." +
                           "-----------------" +
                           "                                        " +
                           " Type 'dascoin' to see how much you have got.");
        currentState = States.hackja1;
    }

    void Hackja2() //hier komt dascoin anders met swat sierenen
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Florean opens the software which it    uses for hacking the people" +
                           "             ---------------Proccessing---------------" +
                           "---------------Cracking-----------------------" +
                           "--------------------------------------------------" +
                           " Done." +
                           "-----------------" +
                           "                                        " +
                           " Type 'dascoin' to see how much you have got.");
        currentState = States.hackja2;
    }

    void Meldingbitcoin1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "The Computer wants your account so you can transfer the money to your second fake account which no one can track it." +
            "You have seen you have got 60 bitcoin." +
            "After 10 minutes an alert pops up. It says '-NOTIFICATION- POLICE IS ON THE WAY -ALERT-'" +
            "'SUGGESTION = CHANGE YOUR WIFI!'" +
            "You want to change your wifi or keep surfing on the computer?" +
            "Type 'yes' to change your wifi or Type   'no' to keep surfing in the computer.");
        currentState = States.meldingbitcoin1;
    }

    void Wifichange()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("'You have changed your wifi, well done." +
                           "Now we can go further'" +
                           "Type 'request' to open the requests window.");
        currentState = States.wifija;
    }

    void Wifinochange()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "You haven't changed your wifi. Well, dont mind it. It does not matter according my calculation'" +
            "You gave your account and there comes a new request menu" +
            "To open the request window type 'request'.");
        currentState = States.wifinee;
    }

    void Meldingbitcoin2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You are continuing with your surf and Type 'request' to go request menu.");
        currentState = States.meldingbitcoin2;
    }


    void Requests1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("             Menu              " +
                           "        What do you want to do, sir?" +
                           "            " +
                           "-Hack" +
                           "                                   " +
                           "-Deepweb" +
                           "                                " +
                           "-Quit");
        currentState = States.requests1;
    }

    void Swats()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "The requests window opened but there is something wrong, because you hear some voices from outside." +
            "                            " +
            "*Siren sound*" +
            "                            " +
            "But you didn't mind it and keep surfed.." +
            "                              " +
            "5 minutes later the fbi polices are forcing to open the doors of your apartment." +
            "You closed the computer and take a look. After 1 minute silence.." +
            "To continue type 'silence'..");
        currentState = States.swats;
    }

    void Swatsend()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("FBI OPEN UP!!" +
                           "--------------------------------" +
                           "---------------------------------" +
                           "They got you arrested, bad luck.." +
                           "------------------------------------------" +
                           "                             " +
                           "           END                         " +
                           "                                    " +
                           "To turn back to the begin type 'mainmenu'.");
        currentState = States.swatsend;
    }

    //DEEPWEB SECTION
    void Deepwebnot1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "Notification--> Caution: The websites that you are going to surf contain forbidden contents." +
            " Be sure you are ready before you logged in. Tip: There may be some website that you can log in with permission. You have for now no permission to go in, so please be careful." +
            " Otherwise your ip will be shown to other users and that can be dangerous." +
            "Type 'continue' to go further.");
        currentState = States.deepwebnot1;
    }

    void Deepwebsurf1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "Now you are officially online in deepweb servers. The dark side of the network you have ever seen. " +
            "You are really wondering what is beyond these websites. You are keep searching and learning all secret deals between country." +
            "Type 'v' to continue.");
        currentState = States.deepwebsurf1;
    }

    void Deepwebsurf1v()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "But you realized after you were on the website only with permission. And that means your ip address is already showing to the users. You just didn't mind it kept going with surfing." +
            " All you read about these forbidden website. If you go in, the hitman will come after you..'" +
            "Type 'surf' to continue with your surfing.");
        currentState = States.deepwebsurf1v;
    }

    void Deepwebsituatie()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "After a while Florean writes to you. It says, 'How many website you logged in means how many point you can actually earn. With these points i can make a bonus surprise for you. I already ordered your surprise, it's on the way.' " +
            "Type 'pizza' to go further. ");
        currentState = States.deepwebsituatie;
    }

    void Deepwebpizza()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "You heard a voice from the door. It may be the surprise what florean ordered or it might be worst than you think." +
            " Do you want to look through to eyedoor or do you want to hide in closet?" +
            "Type 'closet' to hide or Type 'door' to go to door.");
        currentState = States.deepwebpizza;
    }


    void Deepwebeye()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You went to the door and looked to the eye of the door..." +
                           "        ..." +
                           "        ..." +
                           " BAM " +
                           "                       " +
                           "You got shot by hitman from the eyehole.           " +
                           "            END                   " +
                           "       Type 'mainmenu' to go back to Mainmenu.");
        currentState = States.deepwebeye;
    }

    void Deepwebkeuze2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("You are hiding in the closet, and you hear a voice.       " +
                           "*Door opens*                " +
                           "Someone is in the office. Do you want to peek out from closet or do you want to stay still?" +
                           "Type 'peek' to peek out or Type 'stay' to stay still.");
        currentState = States.deepwebkeuze2;
    }

    void Deepwebpeek()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "When you peeked, you saw a man with no hair and with a barcode behind his head. You have never seen someone before like him." +
            "When you open the door of closet a bit, it makes a noise of squeak. The hitman shots reflexively to the closet where you are staying right now! " +
            " And ... BAM!!   one of the bullets got you and you died.                " +
            "              END                    " +
            "Go back to main menu Type 'mainmenu'. ");
        currentState = States.deepwebpeek;
    }

    void Deepwebnopeek()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "You decided to stay in this small closet. When you are staying in, you found something in the closet.. " +
            " It's your taser! You lost it 3 weeks ago. Now you have opportunity to shoot the person who is in the same apartment or you can stay to pray until god helps you out." +
            "Type 'taser' to shock the person or Type 'stay' to stay keep calm. ");
        currentState = States.deepwebnopeek;
    }

    void Deepwebkeuze3()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("1");
        currentState = States.deepwebkeuze3;
    }

    void Deepwebtaser()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "First, you picked a bit and saw the person. Then you have finished him. You just shocked him with your taser and get him arrested. Later on you went to your home and you promised you are never going to sit on strange computers." +
            "            END                   " +
            "Happy ending                          " +
            "Type 'mainmenu' to go back to main menu. ");
        currentState = States.deepwebtaser;
    }

    void Deepwebdoorbell()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "It's your lucky day, dude. While you are staying in the closet, the doorbell just rings. And more several times. You are not sure if the guy in the apartment has gone or what. " +
            "When you opened the doors of closet, you saw no one and opened the door. It was pizza deliverer, and he says 'This pizza is ordered to this address, Enjoy with your meal, dude.'" +
            " *Closes the door* .  You eat some pizza and promised you will never sit back on the strange looked computers." +
            "              END                       " +
            "Type 'mainmenu' to go back to main menu.");
        currentState = States.deepwebdoorbell;
    }

    void Deepwebsurf2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "Now you are officially online in deepweb servers. The dark side of the network you have ever seen. " +
            "You are really wondering what is beyond these websites. You are keep searching and learning all secret deals between country." +
            "Type 'continue' to go further.");
        currentState = States.deepwebsurf2;
    }

    void Deepwebhitman2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(
            "While you are surfing, you feel something behind your head. You think first a man appears behind you and aiming at you.. Actually it is what i exactly said. It was the hitman and BAM! .." +
            "       you were shot behind your head and died." +
            "                      END                     " +
            "Type 'mainmenu' to go back to main menu");
        currentState = States.hitman2;
    }

    void Requests2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("             Menu              " +
                           "        What do you want to do, sir?" +
                           "            " +
                           "-Hack" +
                           "                                   " +
                           "-Deepweb" +
                           "                                " +
                           "-Quit");
        currentState = States.requests2;
    }

    void Quit1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Are you sure you want to quit?");
        Terminal.WriteLine("YES?       NO?");
        currentState = States.quit1;
    }

    void Quit2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Are you sure you want to quit?");
        Terminal.WriteLine("YES?       NO?");
        currentState = States.quit2;
    }

    void Quitja1()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Shut downed..                            " +
                           "--------------------------------------" +
                           "You have shoutdowned the computer, went to your home and want to forget everything what happened today." +
                           "                 --------------------------------" +
                           "Well, nothing happened. If you found out this end, you may be not a excited player. You are not looking for new excitement things :) " +
                           "                                   " +
                           "--------------- END --------------------" +
                           "To turn to the Main menu type 'mainmenu'.");
        currentState = States.quitja1;
    }

    void Quitja2()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine("Shut downed..                            " +
                           "--------------------------------------" +
                           "You have shoutdowned the computer, went to your home and want to forget everything what happened today." +
                           "                 --------------------------------" +
                           "Well, nothing happened. If you found out this end, you may be not a excited player. You are not looking for new excitement things :) " +
                           "                                   " +
                           "--------------- END --------------------" +
                           "To turn to the Main menu type 'mainmenu'.");
        currentState = States.quitja2;
    }
}