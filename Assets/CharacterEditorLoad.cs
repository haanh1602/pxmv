using System.Collections;
using System.Collections.Generic;
using System.Text;
using Assets.HeroEditor4D.Common.CharacterScripts;
using Assets.HeroEditor4D.Common.CommonScripts;
using HeroEditor4D.Common;
using UnityEngine;

public class CharacterEditorLoad : CharacterEditorBase
{
    public void SaveToJson()
        {
            StartCoroutine(StandaloneFilePicker.SaveFile("Save as JSON", "", "New character", "json",
                Encoding.Default.GetBytes(Character.ToJson()),
                (success, path) => { Debug.Log(success ? $"Saved as {path}" : "Error saving."); }));
        }

        /// <summary>
        /// Load character from json.
        /// </summary>
        public void LoadFromJson()
        {
            StartCoroutine(StandaloneFilePicker.OpenFile("Open as JSON", "", "json", (success, path, bytes) =>
            {
                if (success)
                {
                    var json = System.IO.File.ReadAllText(path);

                    Character.FromJson(json, silent: false);
                }
            }));
        }

        public override void Save(string path)
        {
            /*Character.transform.localScale = Vector3.one;

#if UNITY_2018_3_OR_NEWER

            UnityEditor.PrefabUtility.SaveAsPrefabAsset(Character.gameObject, path);

#else

			UnityEditor.PrefabUtility.CreatePrefab(path, Character.gameObject);

#endif

            Debug.LogFormat("Prefab saved as {0}", path);*/
        }

        public override void Load(string path)
        {
            /*var character = UnityEditor.AssetDatabase.LoadAssetAtPath<Character4D>(path);

            Load(character);*/
        }

        protected override void FeedbackTip()
        {
#if UNITY_EDITOR

            var success = UnityEditor.EditorUtility.DisplayDialog("HeroView Editor", "Hi! Thank you for using my asset! I hope you enjoy making your game with it. The only thing I would ask you to do is to leave a review on the Asset Store. It would be awesome support for my asset, thanks!", "Review", "Later");
			
            RequestFeedbackResult(success);

#endif
        }
}
