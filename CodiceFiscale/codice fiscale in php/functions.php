
<?php
function Code_Name() {
    $INPUT_NAME = $_POST['name'];
    $Array_Name = [];
    $Vowels_Name = [];
    $Consonant_Name = [];
    $FiscalCode_Name = "";
    $counter = 0;
    $counter2 = 0;

    // Popola l'array con le lettere del nome
    for ($i = 0; $i < strlen($INPUT_NAME); $i++) {
        $Array_Name[$i] = substr($INPUT_NAME, $i, 1);
    }

    // Separa vocali e consonanti
    for ($i = 0; $i < count($Array_Name); $i++) {
        if ($Array_Name[$i] == "A" || $Array_Name[$i] == "E" || $Array_Name[$i] == "I" || $Array_Name[$i] == "O" || $Array_Name[$i] == "U") {
            $Vowels_Name[$counter] = $Array_Name[$i];
            $counter++;
        } else {
            $Consonant_Name[$counter2] = $Array_Name[$i];
            $counter2++;
        }
    }

    // Genera il codice fiscale basato sulle regole
    if (count($Array_Name) == 2) {
        $FiscalCode_Name = $INPUT_NAME . "X";
    } elseif (count($Array_Name) == 1) {
        $FiscalCode_Name = $INPUT_NAME . "XX";
    } else {
        if (count($Consonant_Name) >= 4) {
            $FiscalCode_Name = $Consonant_Name[0] . $Consonant_Name[2] . $Consonant_Name[3];
        } elseif (count($Consonant_Name) == 3) {
            $FiscalCode_Name = $Consonant_Name[0] . $Consonant_Name[1] . $Consonant_Name[2];
        } elseif (count($Consonant_Name) == 2) {
            $FiscalCode_Name = $Consonant_Name[0] . $Consonant_Name[1] . $Vowels_Name[0];
        }
    }

    return $FiscalCode_Name;
}




function Code_Surname() {
    $INPUT_Surname = $_POST['surname'];
    $Array_Surname = [];
    $Vowels_Surname = [];
    $Consonant_Surname = [];
    $FiscalCode_Surname = "";
    
    // Popola l'array con le lettere del cognome
    for ($i = 0; $i < strlen($INPUT_Surname); $i++) {
        $Array_Surname[$i] = substr($INPUT_Surname, $i, 1);
    }

    $counter = 0;
    $counter2 = 0;

    // Separa vocali e consonanti
    for ($i = 0; $i < count($Array_Surname); $i++) {
        if ($Array_Surname[$i] == "A" || $Array_Surname[$i] == "E" || $Array_Surname[$i] == "I" || $Array_Surname[$i] == "O" || $Array_Surname[$i] == "U") {
            $Vowels_Surname[$counter] = $Array_Surname[$i];
            $counter++;
        } else {
            $Consonant_Surname[$counter2] = $Array_Surname[$i];
            $counter2++;
        }
    }

    // Genera il codice fiscale per il cognome basato sulle regole
    if (strlen($INPUT_Surname) < 2) {
        $FiscalCode_Surname = $INPUT_Surname . "X";
    } elseif (strlen($INPUT_Surname) == 3) {
        $FiscalCode_Surname = $INPUT_Surname;
    } elseif (strlen($INPUT_Surname) > 3) {
        if (count($Consonant_Surname) >= 3) {
            $FiscalCode_Surname = $Consonant_Surname[0] . $Consonant_Surname[1] . $Consonant_Surname[2];
        } elseif (count($Consonant_Surname) == 2) {
            $FiscalCode_Surname = $Consonant_Surname[0] . $Consonant_Surname[1] . $Vowels_Surname[0];
        }
    }

    return $FiscalCode_Surname;
}


function Code_Province() {
    $INPUT_Province = $_POST['provincie']; // Ricevi la provincia dal form
    $Code_Province = substr($INPUT_Province, -5); // Estrae gli ultimi 5 caratteri
    $FiscalCode_Province = substr($Code_Province, 0, 4); // Prende i primi 4 caratteri

    return $FiscalCode_Province;
}
function Code_Date_Sex() {
    $INPUT_Date = $_POST['data']; // Ricevi la data dal form
    $INPUT_Year = substr($INPUT_Date, 2, 2); // Prende l'anno dalla data (ultime due cifre)
    $INPUT_Month = substr($INPUT_Date, 5, 2); // Prende il mese dalla data
    $INPUT_Day = intval(substr($INPUT_Date, 8, 2)); // Prende il giorno dalla data
    $INPUT_Sex = $_POST['sesso']; // Ricevi il sesso dal form (femmina o maschio)
    $Letter_For_Month = '';
    $FiscalCode_Date_Sex = '';

    // Converti il mese in numero
    $INPUT_Month = intval($INPUT_Month);

    // Assegna la lettera corrispondente al mese
    switch ($INPUT_Month) {
        case 1:
            $Letter_For_Month = "A";
            break;
        case 2:
            $Letter_For_Month = "B";
            break;
        case 3:
            $Letter_For_Month = "C";
            break;
        case 4:
            $Letter_For_Month = "D";
            break;
        case 5:
            $Letter_For_Month = "E";
            break;
        case 6:
            $Letter_For_Month = "H";
            break;
        case 7:
            $Letter_For_Month = "L";
            break;
        case 8:
            $Letter_For_Month = "M";
            break;
        case 9:
            $Letter_For_Month = "P";
            break;
        case 10:
            $Letter_For_Month = "R";
            break;
        case 11:
            $Letter_For_Month = "S";
            break;
        case 12:
            $Letter_For_Month = "T";
            break;
    }

    // Aggiungi 40 al giorno se il sesso è femmina
    if ($INPUT_Sex == "femmina") {
        $INPUT_Day += 40;
    }

    // Genera il codice fiscale basato su data e sesso
    $FiscalCode_Date_Sex = $INPUT_Year . $Letter_For_Month . str_pad($INPUT_Day, 2, '0', STR_PAD_LEFT);

    return $FiscalCode_Date_Sex;
}


function calcolaCarattereControllo($codiceFiscale) {
    // Array di corrispondenza dei valori per i caratteri in posizione pari e dispari
    $tabella_dispari = [
        '0' => 1, '1' => 0, '2' => 5, '3' => 7, '4' => 9, '5' => 13, '6' => 15, '7' => 17, '8' => 19, '9' => 21,
        'A' => 1, 'B' => 0, 'C' => 5, 'D' => 7, 'E' => 9, 'F' => 13, 'G' => 15, 'H' => 17, 'I' => 19, 'J' => 21,
        'K' => 1, 'L' => 0, 'M' => 5, 'N' => 7, 'O' => 9, 'P' => 13, 'Q' => 15, 'R' => 17, 'S' => 19, 'T' => 21,
        'U' => 1, 'V' => 0, 'W' => 5, 'X' => 7, 'Y' => 9, 'Z' => 13
    ];

    $tabella_pari = [
        '0' => 0, '1' => 1, '2' => 2, '3' => 3, '4' => 4, '5' => 5, '6' => 6, '7' => 7, '8' => 8, '9' => 9,
        'A' => 0, 'B' => 1, 'C' => 2, 'D' => 3, 'E' => 4, 'F' => 5, 'G' => 6, 'H' => 7, 'I' => 8, 'J' => 9,
        'K' => 10, 'L' => 11, 'M' => 12, 'N' => 13, 'O' => 14, 'P' => 15, 'Q' => 16, 'R' => 17, 'S' => 18, 'T' => 19,
        'U' => 20, 'V' => 21, 'W' => 22, 'X' => 23, 'Y' => 24, 'Z' => 25
    ];

    // Array per calcolare il carattere di controllo
    $tabella_resto = [
        'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
        'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'
    ];

    $somma = 0;

    // Ciclo su ogni carattere del codice fiscale (senza il carattere di controllo)
    for ($i = 0; $i < 15; $i++) {
        $carattere = $codiceFiscale[$i];

        // Se è in posizione dispari (indice 0-based), usa la tabella dispari
        if (($i + 1) % 2 == 1) {
            $somma += $tabella_dispari[$carattere];
        } else {
            // Se è in posizione pari (indice 0-based), usa la tabella pari
            $somma += $tabella_pari[$carattere];
        }
    }

    // Calcola il resto della divisione per 26
    $resto = $somma % 26;

    // Ottieni il carattere di controllo corrispondente
    $carattereControllo = $tabella_resto[$resto];

    return $carattereControllo;
}



?>
