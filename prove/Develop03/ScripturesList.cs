using System;
using System.Collections.Generic;

public class ScripturesList
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScripturesList()
    {
        _random = new Random();
        _scriptures = new List<Scripture>
        {
            new Scripture(
                new ScriptReference("Doctrine and Covenants", 136, 28),
                "If thou art merry, praise the Lord with singing, with music, with dancing, and with a prayer of praise and thanksgiving."
            ),
            new Scripture(
                new ScriptReference("Moroni", 10, 17),
                "And all these gifts come by the Spirit of Christ; and they come unto every man severally, according as he will."
            ),
            new Scripture(
                new ScriptReference("Doctrine and Covenants", 59, 9),
                "And that thou mayest more fully keep thyself unspotted from the world, thou shalt go to the house of prayer and offer up thy sacraments upon my holy day."
            ),
            new Scripture(
                new ScriptReference("Ether", 6, 3),
                "And thus the Lord caused stones to shine in darkness, to give light unto men, women, and children, that they might not cross the great waters in darkness."
            )
        };
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
