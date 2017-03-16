using Protocol.IO;

using Protocol.Types;
using System;

namespace Protocol.Messages
{
	public class TaxCollectorMovementsOfflineMessage : NetworkMessage
	{
		public const uint Id = 6611;

		public TaxCollectorMovement[] movements;

		public override uint ProtocolId
		{
			get
			{
				return (uint)6611;
			}
		}

		public TaxCollectorMovementsOfflineMessage()
		{
		}

		public TaxCollectorMovementsOfflineMessage(TaxCollectorMovement[] movements)
		{
			this.movements = movements;
		}

		public override void Deserialize(IDataReader reader)
		{
			ushort num = reader.ReadUShort();
			this.movements = new TaxCollectorMovement[num];
			for (int i = 0; i < num; i++)
			{
				this.movements[i] = new TaxCollectorMovement();
				this.movements[i].Deserialize(reader);
			}
		}

		public override void Serialize(IDataWriter writer)
		{
			writer.WriteShort((short)((int)this.movements.Length));
			TaxCollectorMovement[] taxCollectorMovementArray = this.movements;
			for (int i = 0; i < (int)taxCollectorMovementArray.Length; i++)
			{
				taxCollectorMovementArray[i].Serialize(writer);
			}
		}
	}
}