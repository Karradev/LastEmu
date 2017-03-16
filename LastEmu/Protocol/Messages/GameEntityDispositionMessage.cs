using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class GameEntityDispositionMessage : NetworkMessage
	{
		public const uint Id = 5693;

		public IdentifiedEntityDispositionInformations disposition;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5693;
			}
		}

		public GameEntityDispositionMessage()
		{
		}

		public GameEntityDispositionMessage(IdentifiedEntityDispositionInformations disposition)
		{
			this.disposition = disposition;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.disposition = new IdentifiedEntityDispositionInformations();
			this.disposition.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			this.disposition.Serialize(writer);
		}
	}
}