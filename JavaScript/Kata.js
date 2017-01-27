function invert(array)
{
    var b = [];
    for (var item in array)
    {
        if(array[item]!=0)
        {
            b.push(-array[item]);
        }
        else
        {
            b.push(0);
        }
    }
    return b;
}