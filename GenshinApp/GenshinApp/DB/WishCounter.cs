using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using GenshinInfo;
using GenshinInfo.Managers;
using GenshinInfo.Models;
using GenshinInfo.Enums;

namespace GenshinApp.DB
{
    internal class WishCounter
    {
        private string value;
        private GachaInfoManager manag;

        public WishCounter()
        {
            manag = new GachaInfoManager();
        }
        //To take a key from this long link
        public void SetKey(string key)
        {
            value = key;
            GachaInfoManager gacha = new GachaInfoManager();
            gacha.SetAuthKeyByUrl(value);
        }
        //Event character banner
        public async Task<List<GachaDataInfo>> CheckCharacterEventWishes()
        {
            return await manag.GetGachaInfos(GachaTypeNum.CharacterEvent);
        }
        //Event weapon banner
        public async Task<List<GachaDataInfo>> CheckWeaponEventWishes()
        {
            return await manag.GetGachaInfos(GachaTypeNum.WeaponEvent);
        }
        //Novice banner
        public async Task<List<GachaDataInfo>> CheckNoviceWishes()
        {
            return await manag.GetGachaInfos(GachaTypeNum.Novice);
        }
        //Standart banner
        public async Task<List<GachaDataInfo>> CheckStandertWishes()
        {
            return await manag.GetGachaInfos(GachaTypeNum.Permanent);
        }
    }
}
