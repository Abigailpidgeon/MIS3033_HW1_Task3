// MIS3033
// Task 3

double totalscore = 0.0;
int counter = 0;
string answer;
string mesg;

do
{
    mesg = "Please enter your score: ";
    Console.Write(mesg);
    string scorestr = Console.ReadLine();
    double score = Convert.ToDouble(scorestr);
    counter++;
    totalscore += score;

    mesg = "Do you have another score to input? ";
    Console.Write(mesg);
    answer = Console.ReadLine();96.

} while (answer.ToLower() == "yes");

double avrgscore = totalscore / counter;
mesg = String.Format("The number of scores enterd is: {0}\n",counter);
Console.Write(mesg);
mesg = String.Format("The average score is {0:F2}\n", avrgscore);
Console.Write(mesg);
