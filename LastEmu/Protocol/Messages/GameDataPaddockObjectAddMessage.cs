using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameDataPaddockObjectAddMessage : NetworkMessage
	{
		public const uint Id = 5990;

		public PaddockItem paddockItemDescription;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5990;
			}
		}

		public GameDataPaddockObjectAddMessage()
		{
		}

		public GameDataPaddockObjectAddMessage(PaddockItem paddockItemDescription)
		{
			this.paddockItemDescription = paddockItemDescription;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.paddockItemDescription = new PaddockItem();
			this.paddockItemDescription.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.paddockItemDescription.Serialize(writer);
		}
	}
}