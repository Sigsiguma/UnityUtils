using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/*
 * 使い方
 * シーン間で引き継ぎたいデータ(intに限る)を
 * utility.others.Storage.Add(登録名, data);
 * にて登録します。
 * 
 *  データを取り出したいときは、
 *  utility.others.Storage.Get(登録名);
 * 
 *  データを更新したいときは、
 *  utility.others.Storage.DataUpdate(登録名, data);
 */
namespace utility.others {
    public static class Storage {
        private static Dictionary<string, int> data_dic_ = new Dictionary<string, int>();

        public static void Add(string data_name, int data) {

            if(data_dic_.ContainsKey(data_name)){
                return;
            }

            data_dic_.Add (data_name, data);
        }

        public static void DataUpdate(string data_name, int data) {

            if(data_dic_.ContainsKey(data_name)) {
                data_dic_ [data_name] = data;
            }
            else {
                Debug.LogError (data_name + " doesn't exist!!!!");
            }
        }

        public static int Get(string data_name) {

            int data = 0;

            if(data_dic_.TryGetValue(data_name, out data)) {
                return data;
            }
            else {
                Debug.LogError (data_name + " doesn't exist!!!!");
                return -1;
            }

        }

        public static void Clear() {
            data_dic_.Clear ();
        }
    }    
}

