using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Challenge_2
{
    class App
    {
        private ClaimsRepository _claimRepo = new ClaimsRepository();
        public void Start()
        {
            SeedMenuList();
            Title = "Komodo Insurance";
            RunMainMenu();
        }
        private void RunMainMenu()
        {
            string prompt = @"
 _   __                          _         _____                                         
| | / /                         | |       |_   _|                                        
| |/ /  ___  _ __ ___   ___   __| | ___     | | _ __  ___ _   _ _ __ __ _ _ __   ___ ___ 
|    \ / _ \| '_ ` _ \ / _ \ / _` |/ _ \    | || '_ \/ __| | | | '__/ _` | '_ \ / __/ _ \
| |\  \ (_) | | | | | | (_) | (_| | (_) |  _| || | | \__ \ |_| | | | (_| | | | | (_|  __/
\_| \_/\___/|_| |_| |_|\___/ \__,_|\___/   \___/_| |_|___/\__,_|_|  \__,_|_| |_|\___\___|
                                                                                         
                                                                                         
Hello Employee of Komodo Insurance. Please enter Desired Course of action.";
            string[] options = { "See all claims", "Take Care of next claim", "Enter a new claim", "Exit" };
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunSeeClaims();
                    break;
                case 1:
                    RunTakeCare();
                    break;
                case 2:
                    RunEnterClaim();
                    break;
                case 3:
                    RunExit();
                    break;

            }
        }
        private void RunSeeClaims()
        {
            Clear();
            List<Claims> listOfClaims= _claimRepo.GetClaims();

            foreach (Claims claim in listOfClaims)
            {
                WriteLine($"Claim ID: {claim.ClaimID}\n" +
                    $"Claim Type: {claim.ClaimType}\n" +
                    $"Description: {claim.Description}\n" +
                    $"Claim Amount: {claim.ClaimAmount}\n" +
                    $"Date Of Incident: {claim.DateOfIncident}\n" +
                    $"Date Of Claim: {claim.DateOfClaim}\n" +
                    $"Is it Valid: {claim.IsValid}");
            }
            WriteLine("Press any key to continue");
            ReadKey();
            RunMainMenu();
        }

        private void RunTakeCare()
        {

        }
        private void RunEnterClaim()
        {

        }
        private void RunExit()
        {
            WriteLine("\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }
        private void SeedMenuList()
        {
            Claims 
        }
    }
}
