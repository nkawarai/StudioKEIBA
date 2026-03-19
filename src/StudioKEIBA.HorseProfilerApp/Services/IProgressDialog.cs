namespace StudioKEIBA.HorseProfilerApp.Services
{
    public interface IProgressDialog
    {
        /// <summary>
        /// 進捗メッセージを更新する
        /// </summary>
        /// <param name="message"></param>
        void UpdateMessage(string message);

        /// <summary>
        /// 進捗率を更新する
        /// </summary>
        /// <param name="percent"></param>
        void UpdateProgressPercent(int percent);

        /// <summary>
        /// 進捗画面を閉じる
        /// </summary>
        void CloseDialog();

        /// <summary>
        /// キャンセレーショントークン
        /// </summary>
        CancellationToken CancellationToken { get; }
    }
}
