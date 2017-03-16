using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class InteractiveElementUpdatedMessage : NetworkMessage
	{
		public const uint Id = 5708;

		public InteractiveElement interactiveElement;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5708;
			}
		}

		public InteractiveElementUpdatedMessage()
		{
		}

		public InteractiveElementUpdatedMessage(InteractiveElement interactiveElement)
		{
			this.interactiveElement = interactiveElement;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.interactiveElement = new InteractiveElement();
			this.interactiveElement.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.interactiveElement.Serialize(writer);
		}
	}
}