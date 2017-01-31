function isOpposite(s1,s2)
{
    if(s1 === s2)
    {
        return false;
    }
    if(s2.length > s1.length)
    {
        var s3 = s1;
        s1 = s2;
        s2 = s3;
    }
    var equal = true;
    for (var item in s1)
    {
        var c= s1[item];
        if(c == c.toUpperCase())
        {
            c = c.toLowerCase();
        }
        else
        {
            c = c.toUpperCase()
        }
        if(c != s2[item])
        {
            equal = false;
            break;
        }
    }
    return equal;
}