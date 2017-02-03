using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pingTool
{
    public class Class_keepResult
    {

        //通番
        int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        //アドレス
        string _address;
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        //開始日時
        DateTime _startDt;
        public DateTime startDt
        {
            get { return _startDt; }
            set { _startDt = value; }
        }
        //最新収集日時
        DateTime _newDt;
        public DateTime newDt
        {
            get { return _newDt; }
            set { _newDt = value; }
        }

        //結果
        // -1　失敗
        // 0  初回
        // 1  成功
        int _status;
        public int status
        {
            get { return _status; }
            set { _status = value; }
        }
        //連続失敗回数
        long _count;
        public long count
        {
            get { return _count; }
            set { _count = value; }
        }
        //最終障害日時
        DateTime _lastDt;
        public DateTime lastDt
        {
            get { return _lastDt; }
            set { _lastDt = value; }
        }
        //復旧回数
        long _recoverCount;
        public long recoverCount
        {
            get { return _recoverCount; }
            set { _recoverCount = value; }
        }
        //メッセージ
        string _message;
        public string message
        {
            get { return _message; }
            set { _message = value; }
        }
        //変化フラグ
        int _changeflg;
        public int changeflg
        {
            get { return _changeflg; }
            set { _changeflg = value; }
        }

    }
}
