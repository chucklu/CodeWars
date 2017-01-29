function howMuchILoveYou(nbPetals)
{
    var array = ["I love you","a little","a lot","passionately","madly","not at all"];
    var i = (nbPetals-1)%6;
    return array[i];
}
