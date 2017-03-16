using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class StatedElementUpdatedMessage : NetworkMessage
	{
		public const uint Id = 5709;

		public StatedElement statedElement;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5709;
			}
		}

		public StatedElementUpdatedMessage()
		{
		}

		public StatedElementUpdatedMessage(StatedElement statedElement)
		{
			this.statedElement = statedElement;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.statedElement = new StatedElement();
			this.statedElement.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.statedElement.Serialize(writer);
		}
	}
}