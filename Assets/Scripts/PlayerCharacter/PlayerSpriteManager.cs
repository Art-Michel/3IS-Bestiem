using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NaughtyAttributes;

public class PlayerSpriteManager : LocalManager<PlayerSpriteManager>

{
    public List<Sprite> RegularSprites;
    public List<Sprite> KeroSprites;
    public List<Sprite> KermitSprites;
    public List<Sprite> AbeilleSprites;
    public List<Sprite> RamboSprites;
    public List<Sprite> TronSprites;

    public List<Sprite> CurrentSprites { get; private set; }

    public void SetCurrentSprites(List<Sprite> spritesToUse)
    {
        CurrentSprites = spritesToUse;
    }

    void Start()
    {
        SetCurrentSprites(RegularSprites);
    }

    [Button]
    void SetKero()
    {
        SetCurrentSprites(KeroSprites);
    }

    [Button]
    void SetRegular()
    {
        SetCurrentSprites(RegularSprites);
    }
}
