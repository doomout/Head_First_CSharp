using System;
using System.Collections.Generic;
using System.Text;

namespace _06_BeehiveManagementSystem
{
    static class HoneyVault
    {
        public const float NECTAR_CONVERSION_RATIO = 0.19f; //꽃꿀 전환율
        public const float LOW_LEVEL_WARNING = 10f; //저수위 경고
        private static float honey = 25f;  //꿀량
        private static float nectar = 100f; //꽃꿀량

        public static void CollectNectar(float amount)
        {
            if (amount > 0f) nectar += amount;
        }

        //꽃꿀로 벌꿀을 만든다.
        public static void ConvertNectarToHoney(float amount)
        {
            float nectarToConvert = amount;
            //amount 값이 창고에 남아 있는 꽃꿀량보다 작다면 남아 있는 모든 꽃꿀로  벌꿀을 만든다.
            if (nectarToConvert > nectar) 
                nectarToConvert = nectar; 
            //꽃꿀을 입력량만큼 뺀다.
            nectar -= nectarToConvert;
            //입력량 * 꽃꿀 전환율 만큼 꿀량을 더한다.
            honey += nectarToConvert * NECTAR_CONVERSION_RATIO;
        }

        //벌들이 일을 하기 위해 벌꿀을 사용하도록 한다.
        public static bool ConsumeHoney(float amount)
        {
            //입력 값이 꿀량보다 작거나 같으면 
            if(honey >= amount)
            {
                honey -= amount; //꿀에서 입력값을 뺀 다음
                return true; //true 반환
            }
            return false; //아니면 false
        }

        // 보고서
        public static string StatusReport
        {
            get
            {
                string status = $"{honey:0.0} units of honey\n" + $"{nectar:0.0} units of nectar";
                string warnings = "";
                //벌꿀량이 최소 양보다 줄어들면 경고
                if (honey < LOW_LEVEL_WARNING) 
                    warnings += "\nLOW HONEY = ADD A HONEY MANUFACTURER";

                //꽃꿀이 최소 양보다 줄어들면 경고
                if (nectar < LOW_LEVEL_WARNING) 
                    warnings += "\nLOW NECTAR - ADD A NECTAR COLLECTOR";
                return status + warnings;
            }
        }
    }
}
