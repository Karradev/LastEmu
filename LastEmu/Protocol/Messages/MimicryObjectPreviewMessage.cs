using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class MimicryObjectPreviewMessage : NetworkMessage
	{
		public const uint Id = 6458;

		public ObjectItem result;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6458;
			}
		}

		public MimicryObjectPreviewMessage()
		{
		}

		public MimicryObjectPreviewMessage(ObjectItem result)
		{
			this.result = result;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.result = new ObjectItem();
			this.result.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.result.Serialize(writer);
		}
	}
}