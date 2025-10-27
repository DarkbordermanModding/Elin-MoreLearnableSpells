using BepInEx;


[BepInPlugin("dbm.morelearnablespells", "More Learnable Spells", "0.0.0")]
public class DBMMoreLearnableSpells : BaseUnityPlugin
{
  public void Start(){
    MoreLearnableSpells.Main();
  }
}
