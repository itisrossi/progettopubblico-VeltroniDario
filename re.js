        function Q(){
        var v = [34,1,7,3,4,2,5,6,9,8,0,234,4654,125265,34673,234523,39,5734,72523,45,];
        let inizio = 0;
        let fine = 19;
            function selectionSort(v, inizio, fine){
	            if (inizio === fine){
		            return;
	            }else {
		            let posMinimo = posizioneMinimo(v, inizio, fine);
                    scambia(v, inizio, posMinimo)
		            selectionSort(v, inizio + 1, fine);
	            }
                
            }
            /*function posizioneMinimo(v, inizio, fine){
                let minimo = v[inizio];
                let posizione = inizio;
                for (let i = inizio+1; i <= fine; i++) {
                    if (minimo > v[i]){
                        minimo = v[i];
                        posizione = i;

                    }
                }
                return pos;
                
            }
            */
            function scambia(v, da, a){
                let tmp = v[da];
                va[da] = v[a];
                v[a] = tmp;
            }
            
            function posizioneMinimo(v, inizio, fine){
                let minimo = posizioneMinimo(v, inizio + 1, fine);
                if (inizio === fine){
                        return inizio;
                }else {
                    if (v[inizio] < v[minimo]){
                        return inizio;

                    }else {
                        return minimo;
                    }
                }
            }
            document.getElementById("E").innerHTML = selectionSort(v, inizio, v.length-1)
        }
            
        
        
            