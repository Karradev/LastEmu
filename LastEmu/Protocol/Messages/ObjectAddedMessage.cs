using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class ObjectAddedMessage : NetworkMessage
	{
		public const uint Id = 3025;

		public ObjectItem @object;

		public override uint ProtocolId
		{
			get
			{
				return (uint)3025;
			}
		}

		public ObjectAddedMessage()
		{
		}

		public ObjectAddedMessage(ObjectItem @object)
		{
			this.@object = @object;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.@object = new ObjectItem();
			this.@object.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.@object.Serialize(writer);
		}
	}
}