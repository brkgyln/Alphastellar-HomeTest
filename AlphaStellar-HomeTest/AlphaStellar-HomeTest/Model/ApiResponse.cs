using System;
using static Entities.CommonEnum;

namespace AlphaStellar_HomeTest
{
    public class ResponseData<T>
    {
        public ResponseDataTypes ResponseDataType { get; set; }
        public string Code { get; set; }
        public string Message { get; set; }
        public DateTime ServerTime { get; set; }
        public int? TotalRowCount { get; set; }
        public T Result { get; set; }

        public ResponseData()
        {
            ServerTime = DateTime.Now;
        }

        public ResponseData<T> Success(T t)
        {
            Code = "INF-00001";
            Message = "İşlem Başarılı";
            ResponseDataType = ResponseDataTypes.Success;
            Result = t;
            return this; 
        }

        public ResponseData<T> NotFound(T t)
        {
            Code = "INFO-0002";
            Message = "Kayıt Bulunamadı";
            ResponseDataType = ResponseDataTypes.Error;
            Result = t;
            return this;
        }

       
    }
}
