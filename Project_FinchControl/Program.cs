using System;
using System.Collections.Generic;
using System.IO;
using FinchAPI;

namespace Project_FinchControl
{

    // **************************************************
    //
    // Title: Finch Control - Menu Starter
    // Description: Starter solution with the helper methods,
    //              opening and closing screens, and the menu
    // Application Type: Console
    // Author: Velis, John
    // Dated Created: 1/22/2020
    // Last Modified: 1/25/2020
    //
    // **************************************************

    class Program
    {
        // **************************************************************************
        //
        // Title: Finch Control
        // Description: Added Alarm System menu options.
        // Application Type: Console
        // Author: Kage-Weir, Nakiah
        // Date Created: 11/03/2020
        // Last Modified: 11/ /2020
        //
        // **************************************************************************

        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            SetTheme();

            DisplayWelcomeScreen();
            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayMenuScreen(finchRobot);
                        break;

                    case "c":
                        DataRecorderDisplayMenuScreen(finchRobot);
                        break;

                    case "d":
                        LightAlarmDisplayMenuScreen(finchRobot);
                        break;

                    case "e":

                        break;

                    case "f":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }


        #region TALENT SHOW

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        static void TalentShowDisplayMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Dance Recital");
                Console.WriteLine("\tc) Light Show");
                Console.WriteLine("\td) Awesome Singing");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        TalentShowDisplayLightAndSound(finchRobot);
                        break;

                    case "b":
                        TalentShowDisplayDanceRecital(finchRobot);
                        break;

                    case "c":
                        TalentShowDisplayLightShow(finchRobot);
                        break;

                    case "d":
                        TalentShowDisplayAwesomeSinging(finchRobot);
                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayLightAndSound(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light and Sound");

            Console.WriteLine("\tThe Finch robot will now show off its glowing talent!");
            DisplayContinuePrompt();

            for (int lightSoundLevel = 0; lightSoundLevel < 255; lightSoundLevel++)
            {
                finchRobot.setLED(lightSoundLevel, lightSoundLevel, lightSoundLevel);
                finchRobot.noteOn(lightSoundLevel * 100);
            }

            DisplayMenuPrompt("Talent Show Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Dance Recital                     *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>

        static void TalentShowDisplayDanceRecital(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Dance Recital");

            Console.WriteLine("\tThe Finch robot will now start it's recital!");
            DisplayContinuePrompt();

            finchRobot.setLED(255, 255, 0);
            finchRobot.wait(2000);
            finchRobot.setMotors(120, 120);
            finchRobot.wait(1000);
            finchRobot.setLED(152, 255, 0);
            finchRobot.wait(2000);
            finchRobot.setMotors(-120, -120);
            finchRobot.wait(1000);
            finchRobot.setLED(0, 255, 255);
            finchRobot.wait(2000);
            finchRobot.setMotors(120, -120);
            finchRobot.wait(1000);
            finchRobot.setLED(0, 152, 255);
            finchRobot.wait(2000);
            ; finchRobot.setMotors(-120, 120);
            finchRobot.wait(1000);
            finchRobot.setLED(0, 0, 0);
            finchRobot.setMotors(0, 0);



            DisplayMenuPrompt("Talent Show Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light Show                        *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void TalentShowDisplayLightShow(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Light Show");

            Console.WriteLine("\tThe Finch robot will now start a wonderful lightshow!");
            DisplayContinuePrompt();

            finchRobot.setLED(0, 102, 204);
            finchRobot.wait(1000);
            finchRobot.setLED(0, 255, 255);
            finchRobot.wait(1000);
            finchRobot.setLED(153, 204, 0);
            finchRobot.wait(1000);
            finchRobot.setLED(24, 232, 123);
            finchRobot.wait(1000);
            finchRobot.setLED(222, 0, 153);
            finchRobot.wait(1000);
            finchRobot.setLED(200, 50, 0);
            finchRobot.wait(1000);
            finchRobot.noteOff();


            DisplayMenuPrompt("Talent Show Menu");

        }

        static void TalentShowDisplayAwesomeSinging(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Singing Master");

            Console.WriteLine("\tThe Finch robot will now show off its awesome voice!");
            DisplayContinuePrompt();
            finchRobot.setLED(0, 0, 0);
            finchRobot.wait(1000);
            finchRobot.setLED(255, 0, 255);
            finchRobot.wait(1000);
            finchRobot.noteOn(523);
            finchRobot.wait(1000);
            finchRobot.setLED(150, 255, 0);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.noteOn(520);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.setLED(0, 255, 150);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.noteOn(784);
            finchRobot.wait(1000);
            finchRobot.setLED(0, 150, 255);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.noteOn(723);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.setLED(0, 0, 255);
            finchRobot.wait(1000);
            finchRobot.noteOn(880);
            finchRobot.wait(1000);
            finchRobot.noteOn(877);
            finchRobot.noteOff();
            finchRobot.setLED(255, 0, 255);
            finchRobot.wait(1000);
            finchRobot.noteOn(784);
            finchRobot.wait(1000);
            finchRobot.noteOff();
            finchRobot.setLED(0, 0, 0);




            DisplayMenuPrompt("Talent show Menu");
        }



        #endregion

        #region DATA RECORDER

        static void DataRecorderDisplayMenuScreen(Finch finchRobot)
        {
            int numberOfDataPoints = 0;
            double dataPointFrequency = 0;
            double[] temperatures = null;

            Console.CursorVisible = true;

            bool quitMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Data Recorder");

                //
                // get user menu choice
                //
                Console.WriteLine("\ta) Number of Data Points");
                Console.WriteLine("\tb) Frequency of Data Points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        numberOfDataPoints = DataRecorderDisplayGetNumberOfDataPoints();
                        break;

                    case "b":
                        dataPointFrequency = DataRecorderDisplayGetDataPointFrequency();
                        break;

                    case "c":
                        temperatures = DataRecorderDisplayGetData(numberOfDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "d":
                        DataRecorderDisplayGetData(temperatures);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitMenu);




        }

        static void DataRecorderDisplayGetData(double[] temperatures)
        {
            DisplayScreenHeader("Data Shown");

            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();
        }

        static void DataRecorderDisplayTable(double[] temperatures)
        {

            //
            // dislay table headers
            //
            Console.WriteLine(
                "Recorded Number | ".PadLeft(10) +
                "Temperature in Celsius".PadLeft(10)
                 );
            Console.WriteLine(
                "..................".PadLeft(10) +
                "......................".PadLeft(10)
                 );

            //
            // Display table data
            //
            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                (index + 1).ToString().PadLeft(10) +
                temperatures[index].ToString("n1").PadLeft(10)
                );
            }
        }

        /// <summary>
        /// Displays an array of data
        /// </summary>
        /// <param name="numberOfDataPoints"></param>
        /// <param name="dataPointFrequency"></param>
        /// <param name="finchRobot"></param>
        /// <returns> displays an array of data</returns>
        static double[] DataRecorderDisplayGetData(int numberOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] temperatures = new double[numberOfDataPoints];
            DisplayScreenHeader("Get Data");

            Console.WriteLine($"\tNumber of Data Points: {numberOfDataPoints}");
            Console.WriteLine($"\tData Point Frequanecy: {dataPointFrequency}");
            Console.WriteLine();
            Console.WriteLine("The tiny robot is ready to begin recording the temperature data. ");
            DisplayContinuePrompt();

            for (int index = 0; index < numberOfDataPoints; index++)
            {
                temperatures[index] = finchRobot.getTemperature();
                Console.WriteLine($"\tReading {index + 1}; {temperatures[index].ToString("n2")}");
                int waitInSeconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(waitInSeconds);
            }


            DisplayContinuePrompt();


            return temperatures;
        }


        /// <summary>
        /// Gets data point frequency from user
        /// </summary>
        /// <returns>data point frequency</returns>
        static double DataRecorderDisplayGetDataPointFrequency()
        {
            double dataPointFrequency;

            DisplayScreenHeader("Data Point Frequency");

            Console.Write("\tPlease enter how frequent you want the data points. ");
            Console.ReadLine();


            // Validate User input
            double.TryParse(Console.ReadLine(), out dataPointFrequency);

            DisplayContinuePrompt();

            return dataPointFrequency;
        }

        /// <summary>
        /// Gets number of data points wanted from user
        /// </summary>
        /// <returns>number of data points</returns>
        static int DataRecorderDisplayGetNumberOfDataPoints()
        {
            int numberOfDataPoints;
            string userResponse;

            DisplayScreenHeader("Number of Data Points");

            Console.Write("\tPlease enter an amount of Data Points you would like. ");
            userResponse = Console.ReadLine();

            // Validate User input
            int.TryParse(userResponse, out numberOfDataPoints);


            DisplayContinuePrompt();

            return numberOfDataPoints;
        }

        #endregion

        #region ALARM SYSTEM

        /// <summary>
        /// ********************************************
        /// *           Light Alarm Menu               *
        /// ********************************************
        /// </summary>
        /// <param name="finchRobot"></param>
        static void LightAlarmDisplayMenuScreen(Finch finchRobot)
        {

            //Switch case menu choice

            {

                Console.CursorVisible = true;

                bool quitMenu = false;
                string menuChoice;

                string sensorsToMonitor = "";
                string rangeType = "";
                int minMaxThresholdValue = 0;
                int timeToMonitor = 0;

                do
                {
                    DisplayScreenHeader("Alarm System Menu");

                    //
                    // get user menu choice
                    //
                    Console.WriteLine("\ta) Set Sensors to Monitor");
                    Console.WriteLine("\tb) Set Range Type");
                    Console.WriteLine("\tc) Set Minimum/Maximum Values");
                    Console.WriteLine("\td) Set Time for Monitoring");
                    Console.WriteLine("\te) Set Alarm");
                    Console.WriteLine("\tq) Main Menu");
                    Console.Write("\t\tEnter Choice:");
                    menuChoice = Console.ReadLine().ToLower();

                    //
                    // process user menu choice
                    //
                    switch (menuChoice)
                    {
                        case "a":
                            sensorsToMonitor = LightAlarmDisplaySetSensorsToMonitor();
                            break;

                        case "b":
                            rangeType = LightAlarmDisplaySetRangeType();
                            break;

                        case "c":
                            minMaxThresholdValue = LightAlarmSetMinMaxthresholdValue(rangeType, finchRobot);
                            break;

                        case "d":
                            timeToMonitor = LightAlarmSetTimeToMonitor();
                            break;

                        case "e":
                            LightAlarmSetAlarm(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                            break;

                        case "q":
                            quitMenu = true;
                            break;

                        default:
                            Console.WriteLine();
                            Console.WriteLine("\tPlease enter a letter for the menu choice.");
                            DisplayContinuePrompt();
                            break;
                    }

                } while (!quitMenu);
            }

            static string LightAlarmDisplaySetSensorsToMonitor()
            {

                string sensorsToMonitor;

                DisplayScreenHeader("Sensors to Monitor");
                               
                Console.WriteLine("\tWhat Sensors would you like to use? Left, right, or Both?");
                sensorsToMonitor = Console.ReadLine();
                
                Console.WriteLine($"\tAlright I will monitor {sensorsToMonitor} sensor(s)");

                DisplayMenuPrompt("Alarm System");

                return sensorsToMonitor;

            }

            static string LightAlarmDisplaySetRangeType()
            {

                string rangeType;


                DisplayScreenHeader("Range Type");

                Console.WriteLine("\tPlease choose minimum or maximum range");
                rangeType = Console.ReadLine();

                Console.WriteLine($"\tAlright I will monitor it with {rangeType} range");

                DisplayMenuPrompt("Alarm System");

                return rangeType;

            }

            static int LightAlarmSetMinMaxthresholdValue(string rangeType, Finch finchRobot)
            {

                int minMaxThresholdValue;

                DisplayScreenHeader("Min/Max Threshold Value");

                Console.WriteLine($"\tLeft Light Sensor Value: {finchRobot.getLeftLightSensor()}");
                Console.WriteLine($"\tRight Light Sensor Value: {finchRobot.getRightLightSensor()}");

                // Validate Value
                Console.Write($"\tEnter the {rangeType} light sensor value:");
                int.TryParse(Console.ReadLine(), out minMaxThresholdValue);
                                
                DisplayMenuPrompt("Alarm System Menu");


                return minMaxThresholdValue;

            }

            static int LightAlarmSetTimeToMonitor()
            {

                int timeTomonitor;

                DisplayScreenHeader("Time to Monitor");


                // Validate Value
                Console.Write($"\tTime to monitor");
                int.TryParse(Console.ReadLine(), out timeTomonitor);

                // Echo Value
                Console.WriteLine($"\tAlright I will monitor it for {timeTomonitor} second(s)");


                DisplayMenuPrompt("Alarm System Menu");

                return timeTomonitor;
            }

            static void LightAlarmSetAlarm(Finch finchRobot, string sensorsToMonitor, string rangeType, int minMaxThresholdValue, int timeToMonitor)
            {
                int secondsElapsed = 0;
                bool thresholdExceeded = false;
                int currentLightSensorValue = 0;

                DisplayScreenHeader("Set Alarm");

                Console.WriteLine($"\tSensors to Monitor: {sensorsToMonitor}");
                Console.WriteLine("\tRange Type: {0}", rangeType);
                Console.WriteLine("\tMin/Max Threshold Value: " + minMaxThresholdValue);
                Console.WriteLine($"\tTime to Monitor: {timeToMonitor}");

                Console.WriteLine("\tPress any key to begin monitoring.");
                Console.ReadKey();
                Console.WriteLine();

                while ((secondsElapsed < timeToMonitor) && !thresholdExceeded)
                {

                    if (thresholdExceeded)
                    {
                        Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} has been exceeded by the current light sensor value(s) of {currentLightSensorValue}.");
                    }
                    else
                    {
                        Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} has not been exceeded by the current light sensor value(s) of {currentLightSensorValue}.");
                    }
                    switch (sensorsToMonitor)
                    {
                        case "left":
                            currentLightSensorValue = finchRobot.getLeftLightSensor();
                            break;

                        case "right":
                            currentLightSensorValue = finchRobot.getRightLightSensor();
                            break;

                        case "both":
                            currentLightSensorValue = (finchRobot.getLeftLightSensor() + finchRobot.getRightLightSensor()) / 2;
                            break;


                    }

                    switch (rangeType)
                    {
                        case "minimum":
                            if (currentLightSensorValue < minMaxThresholdValue)
                            {
                                thresholdExceeded = true;
                            }
                            break;
                        case "maximum":
                            if (currentLightSensorValue > minMaxThresholdValue)
                            {
                                thresholdExceeded = true;
                            }
                            break;

                    }
                    finchRobot.wait(1000);
                    secondsElapsed++;

                }

                DisplayMenuPrompt("Alarm System Menu");
            }
        }

            #endregion

        #region FINCH ROBOT MANAGEMENT

            /// <summary>
            /// *****************************************************************
            /// *               Disconnect the Finch Robot                      *
            /// *****************************************************************
            /// </summary>
            /// <param name="finchRobot">finch robot object</param>
            static void DisplayDisconnectFinchRobot(Finch finchRobot)
            {
                Console.CursorVisible = false;

                DisplayScreenHeader("Disconnect Finch Robot");

                Console.WriteLine("\tAbout to disconnect from the Finch robot.");
                DisplayContinuePrompt();

                finchRobot.disConnect();

                Console.WriteLine("\tThe Finch robot is now disconnect.");

                DisplayMenuPrompt("Main Menu");
            }

            /// <summary>
            /// *****************************************************************
            /// *                  Connect the Finch Robot                      *
            /// *****************************************************************
            /// </summary>
            /// <param name="finchRobot">finch robot object</param>
            /// <returns>notify if the robot is connected</returns>
            static bool DisplayConnectFinchRobot(Finch finchRobot)
            {
                Console.CursorVisible = false;

                bool robotConnected;

                DisplayScreenHeader("Connect Finch Robot");

                Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
                DisplayContinuePrompt();

                robotConnected = finchRobot.connect();

                // TODO test connection and provide user feedback - text, lights, sounds
                finchRobot.setLED(255, 0, 255);
                //DisplayMenuPrompt("Main Menu");

                //
                // reset finch robot
                //
                finchRobot.setLED(0, 0, 0);
                finchRobot.noteOff();

                return robotConnected;
            }

            #endregion

        #region USER INTERFACE

            /// <summary>
            /// *****************************************************************
            /// *                     Welcome Screen                            *
            /// *****************************************************************
            /// </summary>
            static void DisplayWelcomeScreen()
            {
                Console.CursorVisible = false;

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\tFinch Control");
                Console.WriteLine();

                DisplayContinuePrompt();
            }

            /// <summary>
            /// *****************************************************************
            /// *                     Closing Screen                            *
            /// *****************************************************************
            /// </summary>
            static void DisplayClosingScreen()
            {
                Console.CursorVisible = false;

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\tThank you for using Finch Control!");
                Console.WriteLine();

                DisplayContinuePrompt();
            }

            /// <summary>
            /// display continue prompt
            /// </summary>
            static void DisplayContinuePrompt()
            {
                Console.WriteLine();
                Console.WriteLine("\tPress any key to continue.");
                Console.ReadKey();
            }

            /// <summary>
            /// display menu prompt
            /// </summary>
            static void DisplayMenuPrompt(string menuName)
            {
                Console.WriteLine();
                Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
                Console.ReadKey();
            }

            /// <summary>
            /// display screen header
            /// </summary>
            static void DisplayScreenHeader(string headerText)
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("\t\t" + headerText);
                Console.WriteLine();
            }

            #endregion

        
    }

}
