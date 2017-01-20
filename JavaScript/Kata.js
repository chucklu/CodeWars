/**
 * Created by Administrator on 2017/1/10.
 */
function last(list)
{
    if(arguments.length==1)
    {
        var type = Object.prototype.toString.call(list);
        console.log(type);
        if(type=='[object Number]')
        {
            return list;
        }
        return list[list.length-1];
    }
    return arguments[arguments.length-1];
}