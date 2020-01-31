#include <iostream>
using namespace std;

int main() {
   int itemSelect;
   double total = 0.00;
   double budget = 10.00;
   cin >> itemSelect;
   do {
         cout << "Please select a menu item from below" << endl;
         cout << "1 - View menu item" << endl;
         cout << "2 - Pay total due" << endl;
         cout << "3 - Add $5 in credit" << endl;
         cout << "4 - Clear order" << endl;
   
      if ( itemSelect > 4 || itemSelect < 1){
            cout << "Please enter valid option" << endl;
      }
   
       while (itemSelect == 1){
         int menuSelect;
       }
         do {  
            cout << "What would you like to add to your order?"<< endl;
            cout << "(1) Chicken Sandwich: $3.45"<< endl;
            cout << "(2) Chicken Salad: $4.00"<< endl;
            cout << "(3) French Fries: $1.99"<< endl;
            cout << "(4) Hotdog: $2.99"<< endl;
            cout << "(5) Pizza: $3.99"<< endl;
            cout << "(6) Go to main menu"<< endl;
            cout << "Your current total is: $" << total << endl;
            cin >>  menuSelectj;
            if (( menuSelect > 4) || (itemSelect < 6)){
               cout << "Invalid item number please try again" << endl;
            } 
      
            else if (menuSelect == 1){
               cout <<"You have added a chicken Sandwich to your order.";
               total += 3.45;
            }
            else if  (menuSelect == 2){
               cout <<"You have added a chicken salad to your order";
               total += 4.00;
            }
            else if (menuSelect == 3){
               cout <<"You have added french fries to your order.";
               total += 1.99;
            }
            else if (menuSelect == 4){
               cout <<"You have added a hot dog to your order.";
               total += 2.99;
            }
             else if (menuSelect == 5){
               cout <<"You have added a pizza to your order.";
               total += 3.99;
            }
            
         
          while (menuSelect != 6){
             
          }    
      
      else if (itemSelect == 2) {
         if (total> budget){
            cout << "Insuffucient Funds"<< endl;
         }
         else
         {
            cout << "Your total due is: $";
            break;
         }
      }
      else if (itemSelect == 3){
         budget = budget + 5;
           cout << "Credit available: $" << std::fixed << std::setprecision(2) << budget << endl;
      else if (itemSelect == 4){
         (total < budget){
            cout << "Current order balance has been cleared. Current due: $0.00  " <<
              
      }
   
   
   
   
   
   
   
   
   
   
   
   return 0;
}
