using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeCraftResultWithObjectDescMessage : ExchangeCraftResultMessage
	{
		public const uint Id = 5999;

		public ObjectItemNotInContainer objectInfo;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5999;
			}
		}

		public ExchangeCraftResultWithObjectDescMessage()
		{
		}

		public ExchangeCraftResultWithObjectDescMessage(sbyte craftResult, ObjectItemNotInContainer objectInfo) : base(craftResult)
		{
			this.objectInfo = objectInfo;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.objectInfo = new ObjectItemNotInContainer();
			this.objectInfo.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.objectInfo.Serialize(writer);
		}
	}
}