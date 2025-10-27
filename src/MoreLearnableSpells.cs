using System;
using System.Collections.Generic;


public class MoreLearnableSpells
{
  public class ModifySpellData
  {
    public int id;
    public string[] tag;
  }

  public static void Main()
  {
    SourceManager sources = Core.Instance.sources;
    // Add All kind of magic type have all kind of magic form
    string[] alltags = new string[] {
      // note that breathe is ability not spell, IDK why
      "arrow",  // XX 之箭
      "hand",  // XX 之手
      "bolt",  // XX 光線
      "ball",  // XX 之球
      "weapon",  // XX 之歌
      "sword",  //XX 之劍
      "funnel", // XX 具象
      "miasma", // XX 瘴氣
      "bit", // XX 浮游砲
      // "flare", // XX 爆閃, not implemented yet
      // "puddle", // XX 之海, not implemented yet
    };
    List<ModifySpellData> ElementSpells = new List<ModifySpellData> {
      new ModifySpellData{id=910, tag=alltags},  // eleFire
      new ModifySpellData{id=911, tag=alltags},  // eleCold
      new ModifySpellData{id=912, tag=alltags},  // eleLighting
      new ModifySpellData{id=913, tag=alltags},  // eleDarkness
      new ModifySpellData{id=914, tag=alltags},  // eleMind
      new ModifySpellData{id=915, tag=alltags},  // elePoison
      new ModifySpellData{id=916, tag=alltags},  // eleNether
      new ModifySpellData{id=917, tag=alltags},  // eleSound
      new ModifySpellData{id=918, tag=alltags},  // eleNerve
      new ModifySpellData{id=919, tag=alltags},  // eleHoly
      new ModifySpellData{id=920, tag=alltags},  // eleChaos
      new ModifySpellData{id=921, tag=alltags},  // eleMagic
      new ModifySpellData{id=922, tag=alltags},  // eleEther
      new ModifySpellData{id=923, tag=alltags},  // eleAcid
      new ModifySpellData{id=924, tag=alltags},  // eleCut
      new ModifySpellData{id=925, tag=alltags},  // eleImpact
      // new ModifySpellData{id=926, tag=alltags},  // eleVoid, not implemented yet
    };
    foreach (ModifySpellData spell in ElementSpells)
    {
      SourceElement.Row element = sources.elements.map[spell.id];
      element.tag = spell.tag;
    }
    // Add books for some spells
    // Thing is in "BPSRF" format
    // B -> book, P -> potion, S -> scroll, R -> rod, F -> unknown
    List<ModifySpellData> unlockSpells = new List<ModifySpellData>{
      new ModifySpellData{id=8232},  // SpIdentifyG
      new ModifySpellData{id=8241},  // SpUncurseG
      new ModifySpellData{id=8250},  // SpEnchantWeapon
      new ModifySpellData{id=8251},  // SpEnchantWeaponGreat
      new ModifySpellData{id=8255},  // SpEnchantArmor
      new ModifySpellData{id=8256},  // SpEnchantArmorGreat
      new ModifySpellData{id=8280},  // SpLighten
      new ModifySpellData{id=8281},  // SpFaith
      // new ModifySpellData{id=8284},  // SpChangeMaterialLesser, currently broken
      // new ModifySpellData{id=8285},  // SpChangeMaterial, currently broken
      // new ModifySpellData{id=8286},  // SpChangeMaterialG, currently broken
      new ModifySpellData{id=8288, tag=new string[]{"noCostInc"}},  // SpReconstruction
      new ModifySpellData{id=8390, tag=new string[]{"noRandomAbility"}},  //SpWish
      new ModifySpellData{id=8401},  // SpHealHeavy
      new ModifySpellData{id=8406, tag=new string[]{"syncRide","noRandomAbility","noCostInc"}},  // SpHealJure
      new ModifySpellData{id=8480},  // SpCureMutation
      new ModifySpellData{id=8507},  // SpBreath
      new ModifySpellData{id=8550, tag=new string[]{"noRandomAbility"}},  // SpRebirth
      new ModifySpellData{id=8555, tag=new string[]{"noRandomAbility"}},  // SpBrightnessOfLife
      new ModifySpellData{id=8707},  // SpBerserk
      new ModifySpellData{id=8791},  // SpTransmutePutit
      new ModifySpellData{id=8792},  // SpTransmuteCat
      new ModifySpellData{id=9002},  // SpSummonFire
      new ModifySpellData{id=9003},  // SpSummonTentacle
      new ModifySpellData{id=9004, tag=new string[]{"keepInvisi"}},  // SpSummonMonster
      new ModifySpellData{id=9005, tag=new string[]{"keepInvisi"}},  // SpSummonPawn
      new ModifySpellData{id=9006},  // SpSummonYeek
      new ModifySpellData{id=9007},  // SpSummonOrc
      new ModifySpellData{id=9008},  // SpSummonFish
      new ModifySpellData{id=9009},  // SpSummonTako
      new ModifySpellData{id=9010},  // SpSummonShubKid
      new ModifySpellData{id=9051},  // SpSummonTidalWave
      new ModifySpellData{id=9052, tag=new string[]{"keepInvisi"}},  // SpSummonTrooper
      new ModifySpellData{id=9053, tag=new string[]{"keepInvisi"}},  // SpSummonMachine
      new ModifySpellData{id=9054, tag=new string[]{"keepInvisi"}},  // SpSummonDragon
      new ModifySpellData{id=9155, tag=new string[]{"neg","repeat","noRandomAbility"}},  // SpMoonSpear
      new ModifySpellData{id=9160},  // SpExterminate
      new ModifySpellData{id=9500},  // SpWardMonster
      new ModifySpellData{id=9501},  // SpDrawMonster
      new ModifySpellData{id=9502},  // SpDrawMetal
      new ModifySpellData{id=9503},  // SpDrawBacker
    };
    foreach(ModifySpellData spell in unlockSpells)
    {
      SourceElement.Row element = sources.elements.map[spell.id];
      if(!element.thing.Contains("B")){
        element.thing = "B" + element.thing;
      }
      if(spell.tag != null){
        element.tag = spell.tag;
      }
    }
  }
}
