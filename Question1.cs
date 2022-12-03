Using system;

class Loop{
    private int i;

    public Output(){
        for( int i =1; i<9; i ++){
            for(int j = 8; j>0 ; j--){
                Console.WriteLine(1*j + " ");
            }

        }
    }
}

class Question1
{
    static void main (string[] args){
        Loop demo = new Loop();
        demo.Output();

    }
}