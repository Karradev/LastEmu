using Protocol.IO;


using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class TaxCollectorMovementAddMessage : NetworkMessage
	{
		public const uint Id = 5917;

		public TaxCollectorInformations informations;

		public override uint ProtocolId
		{
			get
			{
				return (uint)5917;
			}
		}

		public TaxCollectorMovementAddMessage()
		{
		}

		public TaxCollectorMovementAddMessage(TaxCollectorInformations informations)
		{
			this.informations = informations;
		}

		public override void Deserialize(IDataReader reader)
		{
			this.informations = ProtocolTypeManager.GetInstance<TaxCollectorInformations>(reader.ReadUShort());
			this.informations.Deserialize(reader);
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort(this.informations.TypeId);
			this.informations.Serialize(writer);
		}
	}
}