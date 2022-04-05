/* FOR J=0 TO N-1 STEP 1
   F=0
   MIN=J
   FOR I=J TO N-1-J STEP 1 
     IF Y[I]>Y[I+1] THEN SWAP Y[I],Y[I+1]:F=1
     IF Y[I]<Y[MIN] THEN MIN=I
   NEXT I
   IF F=0 THEN EXIT FOR
   IF MIN<>J THEN SWAP Y[J],Y[MIN]
 NEXT J*/
int temp;
int[] array1 = new int[] { 9, 3, 1, 2, 9 };
int f = 0;
int min;
for(int i = 0; i < array1.Length; i++)
{
    min = i;
    for(int l = i; i < array1.Length - i; i++)
    {
        if(array1[i] > array1[i + 1])
        {
            temp = array1[l];
            array1[l] = array1[l + 1];
            array1[l + 1] = temp;
            f = 1;
        }
        if(array1[i] < array1[min])
        {
            min = l;
        }
        if (f == 0)
            break;
        if(min != i)
        {
            temp = array1[i];
            array1[i] = array1[min];
            array1[min] = temp;
        }
    }
}