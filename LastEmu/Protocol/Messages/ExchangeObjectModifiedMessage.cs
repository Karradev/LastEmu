using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeObjectModifiedMessage : ExchangeObjectMessage
	{
		public const uint Id = 5519;

		public ObjectItem @object;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5519;
			}
		}

		public ExchangeObjectModifiedMessage()
		{
		}

		public ExchangeObjectModifiedMessage(bool remote, ObjectItem @object) : base(remote)
		{
			this.@object = @object;
		}

		public override void Deserialize(IDataReader reader)
		{
			base.Deserialize(reader);
			this.@object = new ObjectItem();
			this.@object.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			base.Serialize(writer);
			this.@object.Serialize(writer);
		}
	}
}