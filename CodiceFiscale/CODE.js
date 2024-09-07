
















function FunctionFiscalCode(){
   surname = document.getElementById("ICOGN").value;
   Name = document.getElementById("INOM").value;


   if (surname == surname.toUpperCase() && Name == Name.toUpperCase() ){
    document.getElementById("ICONTR").innerHTML = "";
    let RESULT = "Codice Fiscale:   " + Code_Surname() + Code_Name() + Code_Date_Sex() + Code_Province() + Code_CheckCharacter();
    document.getElementById("result").innerHTML = RESULT;
    return RESULT
   }else{
    document.getElementById("ICONTR").innerHTML = "INSERIRE IL TESTO IN MAIUSCOLO!!!!!!";
    
   }
    
   
    

}
function Code_CheckCharacter(){
    let Incomplete_Code;
    var Array_Incomplete_Code = [];
    var Even_Position = [];
    var Odd_Position = [];
    var Numbers_For_Even_Position = [];
    var Letters_For_Even_Position = [];
    var Numbers_For_Odd_Position = [];
    var Letters_For_Odd_Position = [];
    var Trasformation_Letters_For_Even_Position = [];
    var Trasformation_Letters_For_Odd_Position = [];
    var Trasformation_Numbers_For_Odd_Position = [];
    let Letter_Check_Character;
    let Division_Sum_Numbers;
    let Sum_Numbers = 0;
    let counter = 0;
    let counter2 = 0;
    let Even_Odd = 1;

    Incomplete_Code = Code_Surname() + Code_Name() + Code_Date_Sex() + Code_Province();

    for (let i = 0; i < Incomplete_Code.length; i++) {
        Array_Incomplete_Code[i] = Incomplete_Code[i]
    }

    for (let i = 0; i < Array_Incomplete_Code.length; i++) {
        if (Even_Odd == 0){
            Even_Position[counter] = Array_Incomplete_Code[i];
            counter = counter + 1;
            Even_Odd = 1;
        } else if (Even_Odd == 1){
            Odd_Position[counter2] = Array_Incomplete_Code[i];
            counter2 = counter2 + 1;
            Even_Odd = 0;
        }
    }

    counter = 0;
    counter2 = 0;

    for (let i = 0; i < Even_Position.length; i++) {
        switch (Even_Position[i]){
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                Numbers_For_Even_Position[counter] = Even_Position[i];
                counter = counter + 1;
                break;
            case "A":
            case "B":
            case "C":
            case "D":
            case "E":
            case "F":
            case "G":
            case "H":
            case "I":
            case "J":
            case "K":
            case "L":
            case "M":
            case "N":
            case "O":
            case "P":
            case "Q":
            case "R":
            case "S":
            case "T":
            case "U":
            case "V":
            case "W":
            case "X":
            case "Y":
            case "Z":
                Letters_For_Even_Position[counter2] = Even_Position[i];
                counter2 = counter2 + 1;
                break;
            
            
        }
    }

    counter = 0;
    counter2 = 0;

    for (let i = 0; i < Odd_Position.length; i++) {
        switch (Odd_Position[i]){
            case "0":
            case "1":
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
                Numbers_For_Odd_Position[counter] = Odd_Position[i];
                counter = counter + 1;
                break;
            case "A":
            case "B":
            case "C":
            case "D":
            case "E":
            case "F":
            case "G":
            case "H":
            case "I":
            case "J":
            case "K":
            case "L":
            case "M":
            case "N":
            case "O":
            case "P":
            case "Q":
            case "R":
            case "S":
            case "T":
            case "U":
            case "V":
            case "W":
            case "X":
            case "Y":
            case "Z":
                Letters_For_Odd_Position[counter2] = Odd_Position[i];
                counter2 = counter2 + 1;
                break;
            
            
        }
    }

    counter = 0;
    counter2 = 0;
   
    for (let i = 0; i < Letters_For_Even_Position.length; i++) {
        switch (Letters_For_Even_Position[i]){
            case "A":
                Trasformation_Letters_For_Even_Position[counter] = 0;
                counter = counter + 1;
                break;
            case "B":
                Trasformation_Letters_For_Even_Position[counter] = 1;
                counter = counter + 1;
                break;
            case "C":
                Trasformation_Letters_For_Even_Position[counter] = 2;
                counter = counter + 1;
                break;
            case "D":
                Trasformation_Letters_For_Even_Position[counter] = 3;
                counter = counter + 1;
                break;
            case "E":
                Trasformation_Letters_For_Even_Position[counter] = 4;
                counter = counter + 1;
                break;
            case "F":
                Trasformation_Letters_For_Even_Position[counter] = 5;
                counter = counter + 1;
                break;
            case "G":
                Trasformation_Letters_For_Even_Position[counter] = 6;
                counter = counter + 1;
                break;
            case "H":
                Trasformation_Letters_For_Even_Position[counter] = 7;
                counter = counter + 1;
                break;
            case "I":
                Trasformation_Letters_For_Even_Position[counter] = 8;
                counter = counter + 1;
                break;
            case "J":
                Trasformation_Letters_For_Even_Position[counter] = 9;
                counter = counter + 1;
                break;
            case "K":
                Trasformation_Letters_For_Even_Position[counter] = 10;
                counter = counter + 1;
                break;
            case "L":
                Trasformation_Letters_For_Even_Position[counter] = 11;
                counter = counter + 1;
                break;
            case "M":
                Trasformation_Letters_For_Even_Position[counter] = 12;
                counter = counter + 1;
                break;
            case "N":
                Trasformation_Letters_For_Even_Position[counter] = 13;
                counter = counter + 1;
                break;
            case "O":
                Trasformation_Letters_For_Even_Position[counter] = 14;
                counter = counter + 1;
                break;
            case "P":
                Trasformation_Letters_For_Even_Position[counter] = 15;
                counter = counter + 1;
                break;
            case "Q":
                Trasformation_Letters_For_Even_Position[counter] = 16;
                counter = counter + 1;
                break;
            case "R":
                Trasformation_Letters_For_Even_Position[counter] = 17;
                counter = counter + 1;
                break;
            case "S":
                Trasformation_Letters_For_Even_Position[counter] = 18;
                counter = counter + 1;
                break;
            case "T":
                Trasformation_Letters_For_Even_Position[counter] = 19;
                counter = counter + 1;
                break;
            case "U":
                Trasformation_Letters_For_Even_Position[counter] = 20;
                counter = counter + 1;
                break;
            case "V":
                Trasformation_Letters_For_Even_Position[counter] = 21;
                counter = counter + 1;
                break;
            case "W":
                Trasformation_Letters_For_Even_Position[counter] = 22;
                counter = counter + 1;
                break;
            case "X":
                Trasformation_Letters_For_Even_Position[counter] = 23;
                counter = counter + 1;
                break;
            case "Y":
                Trasformation_Letters_For_Even_Position[counter] = 24;
                counter = counter + 1;
                break;
            case "Z":
                Trasformation_Letters_For_Even_Position[counter] = 25;
                counter = counter + 1;
                break;
        }

        
    }

   counter = 0;
   counter2 = 0;
    

    for (let i = 0; i < Letters_For_Odd_Position.length; i++) {
        switch (Letters_For_Odd_Position[i]){
            case "A":
                Trasformation_Letters_For_Odd_Position[counter] = 1;
                counter = counter + 1;
                break;
            case "B":
                Trasformation_Letters_For_Odd_Position[counter] = 0;
                counter = counter + 1;
                break;
            case "C":
                Trasformation_Letters_For_Odd_Position[counter] = 5;
                counter = counter + 1;
                break;
            case "D":
                Trasformation_Letters_For_Odd_Position[counter] = 7;
                counter = counter + 1;
                break;
            case "E":
                Trasformation_Letters_For_Odd_Position[counter] = 9;
                counter = counter + 1;
                break;
            case "F":
                Trasformation_Letters_For_Odd_Position[counter] = 13;
                counter = counter + 1;
                break;
            case "G":
                Trasformation_Letters_For_Odd_Position[counter] = 15;
                counter = counter + 1;
                break;
            case "H":
                Trasformation_Letters_For_Odd_Position[counter] = 17;
                counter = counter + 1;
                break;
            case "I":
                Trasformation_Letters_For_Odd_Position[counter] = 19;
                counter = counter + 1;
                break;
            case "J":
                Trasformation_Letters_For_Odd_Position[counter] = 21;
                counter = counter + 1;
                break;
            case "K":
                Trasformation_Letters_For_Odd_Position[counter] = 2;
                counter = counter + 1;
                break;
            case "L":
                Trasformation_Letters_For_Odd_Position[counter] = 4;
                counter = counter + 1;
                break;
            case "M":
                Trasformation_Letters_For_Odd_Position[counter] = 18;
                counter = counter + 1;
                break;
            case "N":
                Trasformation_Letters_For_Odd_Position[counter] = 20;
                counter = counter + 1;
                break;
            case "O":
                Trasformation_Letters_For_Odd_Position[counter] = 11;
                counter = counter + 1;
                break;
            case "P":
                Trasformation_Letters_For_Odd_Position[counter] = 3;
                counter = counter + 1;
                break;
            case "Q":
                Trasformation_Letters_For_Odd_Position[counter] = 6;
                counter = counter + 1;
                break;
            case "R":
                Trasformation_Letters_For_Odd_Position[counter] = 8;
                counter = counter + 1;
                break;
            case "S":
                Trasformation_Letters_For_Odd_Position[counter] = 12;
                counter = counter + 1;
                break;
            case "T":
                Trasformation_Letters_For_Odd_Position[counter] = 14;
                counter = counter + 1;
                break;
            case "U":
                Trasformation_Letters_For_Odd_Position[counter] = 16;
                counter = counter + 1;
                break;
            case "V":
                Trasformation_Letters_For_Odd_Position[counter] = 10;
                counter = counter + 1;
                break;
            case "W":
                Trasformation_Letters_For_Odd_Position[counter] = 22;
                counter = counter + 1;
                break;
            case "X":
                Trasformation_Letters_For_Odd_Position[counter] = 25;
                counter = counter + 1;
                break;
            case "Y":
                Trasformation_Letters_For_Odd_Position[counter] = 24;
                counter = counter + 1;
                break;
            case "Z":
                Trasformation_Letters_For_Odd_Position[counter] = 23;
                counter = counter + 1;
                break;
        }
    }

    counter = 0;

    for (let i = 0; i < Numbers_For_Odd_Position.length; i++) {
        switch (Numbers_For_Odd_Position[i]){
            case "0":
                Trasformation_Numbers_For_Odd_Position[counter] = 1;
                counter = counter + 1;
                break
            case "1":
                Trasformation_Numbers_For_Odd_Position[counter] = 0;
                counter = counter + 1;
                break
            case "2":
                Trasformation_Numbers_For_Odd_Position[counter] = 5;
                counter = counter + 1;
                break
            case "3":
                Trasformation_Numbers_For_Odd_Position[counter] = 7;
                counter = counter + 1;
                break
            case "4":
                Trasformation_Numbers_For_Odd_Position[counter] = 9;
                counter = counter + 1;
                break
            case "5":
                Trasformation_Numbers_For_Odd_Position[counter] = 13;
                counter = counter + 1;
                break
            case "6":
                Trasformation_Numbers_For_Odd_Position[counter] = 15;
                counter = counter + 1;
                break
            case "7":
                Trasformation_Numbers_For_Odd_Position[counter] = 17;
                counter = counter + 1;
                break
            case "8":
                Trasformation_Numbers_For_Odd_Position[counter] = 19;
                counter = counter + 1;
                break
            case "9":
                Trasformation_Numbers_For_Odd_Position[counter] = 21;
                counter = counter + 1;
                break
        }
    }

    for (let i = 0; i < Numbers_For_Even_Position.length; i++) {
        Sum_Numbers = Sum_Numbers + Number(Numbers_For_Even_Position[i])
    }
    for (let i = 0; i < Trasformation_Numbers_For_Odd_Position.length; i++) {
        Sum_Numbers = Sum_Numbers + Number(Trasformation_Numbers_For_Odd_Position[i])
    }
    
    for (let i = 0; i < Trasformation_Letters_For_Even_Position.length; i++) {
        Sum_Numbers = Sum_Numbers + Number(Trasformation_Letters_For_Even_Position[i]);
    }

    for (let i = 0; i < Trasformation_Letters_For_Odd_Position.length; i++) {
        Sum_Numbers = Sum_Numbers + Number(Trasformation_Letters_For_Odd_Position[i]);
    }
    
    Division_Sum_Numbers = Sum_Numbers % 26

    switch (Division_Sum_Numbers){
        case 0:
            Letter_Check_Character = "A";
            break;
        case 1:
            Letter_Check_Character = "B";
            break;
        case 2:
            Letter_Check_Character = "C";
            break;
        case 3:
            Letter_Check_Character = "D";
            break;
        case 4:
            Letter_Check_Character = "E";
            break;
        case 5:
            Letter_Check_Character = "F";
            break;
        case 6:
            Letter_Check_Character = "G";
            break;
        case 7:
            Letter_Check_Character = "H";
            break;
        case 8:
            Letter_Check_Character = "I";
            break;
        case 9:
            Letter_Check_Character = "J";
            break;
        case 10:
            Letter_Check_Character = "K";
            break;
        case 11:
            Letter_Check_Character = "L";
            break;
        case 12:
            Letter_Check_Character = "M";
            break;
        case 13:
            Letter_Check_Character = "N";
            break;
        case 14:
            Letter_Check_Character = "O";
            break;
        case 15:
            Letter_Check_Character = "P";
            break;
        case 16:
            Letter_Check_Character = "Q";
            break;
        case 17:
            Letter_Check_Character = "R";
            break;
        case 18:
            Letter_Check_Character = "S";
            break;
        case 19:
            Letter_Check_Character = "T";
            break;
        case 20:
            Letter_Check_Character = "U";
            break;
        case 21:
            Letter_Check_Character = "V";
            break;
        case 22:
            Letter_Check_Character = "W";
            break;
        case 23:
            Letter_Check_Character = "X";
            break;
        case 24:
            Letter_Check_Character = "Y";
		    break;
        case 25:
		    Letter_Check_Character = "Z";
		    break;


    }

    return Letter_Check_Character
    
}
function Code_Date_Sex(){
    let INPUT_Date = document.getElementById("data").value;
    let INPUT_Year = INPUT_Date.slice(2, 4);                                                     // dalla data si prende l'anno
    let INPUT_Month = INPUT_Date.slice(5, 7);                                                     // dalla data si prende il mese
    let INPUT_Day = Number(INPUT_Date.slice(8, 10));
    let Letter_For_Month;
    let FiscalCode_Date_Sex;
    let INPUT_Sex = document.querySelector('input[name="sesso"]:checked').value;                    //"sesso" contiene l'input del sesse

    INPUT_Month = Number(INPUT_Month)
    switch (INPUT_Month){
        case 1:
            Letter_For_Month = "A";
            break;
        case 2:
            Letter_For_Month = "B";
            break;
        case 3:
            Letter_For_Month = "C";
            break;
        case 4:
            Letter_For_Month = "D";
            break;
        case 5:
            Letter_For_Month = "E";
            break;
        case 6:
            Letter_For_Month = "H";
            break;
        case 7:
            Letter_For_Month = "L";
            break;
        case 8:
            Letter_For_Month = "M";
            break;
        case 9:
            Letter_For_Month = "P";
            break;
        case 10:
            Letter_For_Month = "R";
            break;
        case 11:
            Letter_For_Month = "S";
            break;
        case 12:
            Letter_For_Month = "T";
            break;
    }

    if (INPUT_Sex == "femmina"){
        INPUT_Day = INPUT_Day + 40;
    }
    
    FiscalCode_Date_Sex = INPUT_Year + Letter_For_Month + INPUT_Day;
    return FiscalCode_Date_Sex;
}
function Code_Name(){
    let INPUT_NAME = document.getElementById("INOM").value;
    var Array_Name = [];
    var Vowels_Name = [];
    var Consonant_Name = [];
    let FiscalCode_Name = "";
    let counter = 0;
    let counter2 = 0;

    for (let i = 0; i < INPUT_NAME.length; i++) {
        Array_Name[i] = INPUT_NAME.slice(i,i+1)
    }
    for (let i = 0; i < Array_Name.length; i++) {
        if (Array_Name[i] == "A"){
            Vowels_Name[counter] = Array_Name[i];
            counter = counter + 1;
        }else {
            if (Array_Name[i] == "E"){
                Vowels_Name[counter] = Array_Name[i];
                counter = counter + 1;
            }else{
                if (Array_Name[i] == "I"){
                    Vowels_Name[counter] = Array_Name[i];
                    counter = counter + 1;
                }else {
                    if (Array_Name[i] == "O"){
                        Vowels_Name[counter] = Array_Name[i];
                        counter = counter + 1;
                    }else {
                        if (Array_Name[i] == "U"){
                            Vowels_Name[counter] = Array_Name[i];
                            counter = counter + 1;
                        }else{
                            Consonant_Name[counter2] = Array_Name[i];
                            counter2 = counter2 + 1;
                        }
                    }
                }
            }
        }
    }
    if (Array_Name.length == 2){
            FiscalCode_Name = INPUT_NAME + "X";
    }else{
        if (Array_Name.length == 1){
        FiscalCode_Name = INPUT_NAME + "XX";
    }else{
        if (Consonant_Name.length >= 4){
        FiscalCode_Name = Consonant_Name[0] + Consonant_Name[2] + Consonant_Name[3];
    }else{
        if (Consonant_Name.length == 3){
        FiscalCode_Name = Consonant_Name[0] + Consonant_Name[1] + Consonant_Name[2];
    }else{
        if (Consonant_Name.length == 2){
        FiscalCode_Name = Consonant_Name[0] + Consonant_Name[1] + Vowels_Name[0];
    }
    }
    }
    }
    }
    
    
    return FiscalCode_Name;
}
function Code_Surname(){
    let INPUT_Surname = document.getElementById("ICOGN").value;
    var Array_Surname = [];
    var Vowels_Surname = [];
    var Consonant_Surname = [];
    let FiscalCode_Surname;
    
    for (let i = 0; i < INPUT_Surname.length; i++) {
        Array_Surname[i] = INPUT_Surname.slice(i, i+1);
    }
    
    let counter = 0;
    let counter2 = 0;
    
    for (let i = 0; i < Array_Surname.length; i++) {
        if (Array_Surname[i] == "A"){
            Vowels_Surname[counter] = Array_Surname[i];
            counter = counter + 1;
        }else {
            if (Array_Surname[i] == "E"){
                Vowels_Surname[counter] = Array_Surname[i];
                counter = counter + 1;
            }else{
                if (Array_Surname[i] == "I"){
                    Vowels_Surname[counter] = Array_Surname[i];
                    counter = counter + 1;
                }else {
                    if (Array_Surname[i] == "O"){
                        Vowels_Surname[counter] = Array_Surname[i];
                        counter = counter + 1;
                    }else {
                        if (Array_Surname[i] == "U"){
                            Vowels_Surname[counter] = Array_Surname[i];
                            counter = counter + 1;
                        }else{
                            Consonant_Surname[counter2] = Array_Surname[i];
                            counter2 = counter2 + 1;
                        }
                    }
                }
            }
        }
    }
    
    if (INPUT_Surname.length < 2){
        FiscalCode_Surname = Surname + "X";
    }else if (INPUT_Surname.length == 3){
        FiscalCode_Surname = Surname;
    }else if (INPUT_Surname.length > 3){
        if (Consonant_Surname.length >= 3){
            FiscalCode_Surname = Consonant_Surname[0] + Consonant_Surname[1] + Consonant_Surname[2];
        }
        if (Consonant_Surname.length ==2){
            FiscalCode_Surname = Consonant_Surname[0] + Consonant_Surname[1] + Vowels_Surname[0];
        }
    }
    return FiscalCode_Surname;
}
function Code_Province(){
    let INPUT_Province = document.querySelector('input[name="provincie"]');
    let INPUT_String_Province = INPUT_Province.value;
    let Code_Province = INPUT_String_Province.slice(-5);
    let FiscalCode_Province = Code_Province.slice(0, 4)

    return FiscalCode_Province
}









