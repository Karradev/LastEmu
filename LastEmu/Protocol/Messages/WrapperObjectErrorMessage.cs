using Protocol.IO;
using System;

namespace Protocol.Messages
{
	public class WrapperObjectErrorMessage : SymbioticObjectErrorMessage
	{
		public const uint Id = 6529;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6529;
			}
		}

		public WrapperObjectErrorMessage()
		{
		}

		public WrapperObjectErrorMessage(sbyte reason, sbyte errorCode) : base(reason, errorCode)
		{
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
		}
	}
}