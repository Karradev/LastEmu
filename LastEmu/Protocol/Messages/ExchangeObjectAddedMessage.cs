using Protocol.IO;
using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ExchangeObjectAddedMessage : ExchangeObjectMessage
	{
		public const uint Id = 5516;

		public ObjectItem @object;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5516;
			}
		}

		public ExchangeObjectAddedMessage()
		{
		}

		public ExchangeObjectAddedMessage(bool remote, ObjectItem @object) : base(remote)
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